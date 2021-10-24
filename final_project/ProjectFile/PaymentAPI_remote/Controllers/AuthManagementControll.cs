using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Payment.Configuration;
using Payment.Data; 
using PaymentJWT.Configuration;
using PaymentJWTRefreshToken.Models;
using PaymentJWT.Models.DTOs.Requests;
using Payment.Models.DTOs.Responses;
using PaymentJWTRefreshToken.Models.DTos.Requests;


namespace TodoAppJWT.Controllers
{
     //==api/authManagement==
    [Route("api/[controller]")]
    [ApiController]

    public class AuthManagementController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtConfig _jwtConfig;
        private readonly TokenValidationParameters _tokenValidationParams;
        private readonly ApiDbContext _apiDbContext;

        public AuthManagementController(
            UserManager<IdentityUser> userManager,
            IOptionsMonitor<JwtConfig> optionsMonitor,
            TokenValidationParameters tokenValidationParams,
            ApiDbContext apiDbContext
        )

        {
            _userManager = userManager;
            _jwtConfig = optionsMonitor.CurrentValue;
            _tokenValidationParams = tokenValidationParams;
            _apiDbContext = apiDbContext;
        }

        //==regist new user==
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationDto user)
        {
            if(ModelState.IsValid)
            {
                //==utilise the model==
                var existingUser = await _userManager.FindByEmailAsync(user.Email);

                if(existingUser != null)
                {
                    return BadRequest(new RegistrationResponse() {
                        Errors = new List<string>() {
                            "Email already in use"
                        },
                        Success = false
                    });
                }

                var newUser = new IdentityUser() {Email = user.Email, UserName = user.Username};
                var isCreated = await _userManager.CreateAsync(newUser, user.Password);

                if(isCreated.Succeeded) 
                {
                    var jwtToken = await GenerateJwtToken(newUser);
                    // return Ok(jwtToken);
                    return Ok("{\n  \"success\":true\n}");
                } 
                else {
                    return BadRequest(new RegistrationResponse() {
                        Errors = isCreated.Errors.Select(x => x.Description).ToList(),
                        Success = false
                    });
                }
            }

            return BadRequest(new RegistrationResponse() {
                Errors = new List<string>() {
                    "Invalid Payload"
                },
                Success = false
            });
        }

        private async Task<AuthResult> GenerateJwtToken(IdentityUser user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new [] {
                    new Claim("Id", user.Id),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(10), 
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            var refreshToken = new RefreshToken()
            {
                JwtId = token.Id,
                IsUsed = false,
                UserId = user.Id,
                AddedDate = DateTime.UtcNow,
                ExpiryDate = DateTime.UtcNow.AddMonths(6),
                Token = RandomString(35) + Guid.NewGuid()
            };

            await _apiDbContext.RefreshTokens.AddAsync(refreshToken);
            await _apiDbContext.SaveChangesAsync();

            return new AuthResult() {
                Token = jwtToken,
                Success = true,
                RefreshToken = refreshToken.Token
            };
        }

        private string RandomString(int length)
        {
            var random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string (Enumerable.Repeat(chars, length) .Select(x => x[random.Next(x.Length)]).ToArray());
        }

        //==user login==
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest user)
        {
            if(ModelState.IsValid) 
            {
                var existingUser = await _userManager.FindByEmailAsync(user.Email);

                if(existingUser == null)
                {
                    return BadRequest(new RegistrationResponse() {
                        Errors = new List<string>() {
                            "Invalid login request"
                        },
                        Success = false
                    });
                }

                var isCorrect = await _userManager.CheckPasswordAsync(existingUser, user.Password);

                if(!isCorrect) 
                {
                    return BadRequest(new RegistrationResponse() {
                        Errors = new List<string>() {
                            "Invalid login request"
                        },
                        Success = false
                    });
                }

                var jwtToken = await GenerateJwtToken(existingUser);
                return Ok(jwtToken);
            }

            return BadRequest(new RegistrationResponse() {
                Errors = new List<string>() {
                    "Invalid Payload"
                },
                Success = false
            });
        }

        //==refresh token==
        [HttpPost]
        [Route("RefreshToken")]
        public async Task<IActionResult> RefreshToken([FromBody] TokenRequest tokenRequest)
        {
            if(ModelState.IsValid)
            {
                var result = await VerifyAndGenerateToken(tokenRequest);

                if(result == null)
                {
                    return BadRequest(new RegistrationResponse() {
                        Errors = new List<string>() {
                            "Invalid Tokens"
                        },
                        Success = false
                    });
                }
                return Ok(result);
            }

            return BadRequest(new RegistrationResponse() {
                Errors = new List<string>() {
                    "Invalid Payloads"
                },
                Success = false
            });
        }

        //==verify&generate token==
        [ApiExplorerSettings(IgnoreApi = true)] //==untuk solve error swagger : Failed to load API===
        public async Task<AuthResult> VerifyAndGenerateToken(TokenRequest tokenRequest)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            try
            {
                //==1st validation => validate JWT token format==
                var tokenVerification = jwtTokenHandler.ValidateToken(tokenRequest.Token, _tokenValidationParams, out var validatedToken);

                //==2nd validation => validate encrypt algho
                if(validatedToken is JwtSecurityToken jwtSecurityToken)
                {
                    var result = jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase);

                    if(result == false)
                    {
                        return null;
                    }
                }

                //==3rd validation==
                var utcExpiryDate = long.Parse(tokenVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Exp).Value);

                var expiryDate = UnixTimeStampToDateTime(utcExpiryDate);

                if(expiryDate > DateTime.UtcNow)
                {
                    return new AuthResult() {
                        Success = false,
                        Errors = new List<string>() {
                            "Token has not yet expired"
                        }
                    };
                }

                //==4th validation => validate existence of the token
                var storedToken = await _apiDbContext.RefreshTokens.FirstOrDefaultAsync(x => x.Token == tokenRequest.RefreshToken);

                if(storedToken == null)
                {
                    return new AuthResult() {
                        Success = false,
                        Errors = new List<String>() {
                            "Token does not exist"
                        }
                    };
                }

                //==5th validation => validate if token already used==
                if(storedToken.IsUsed)
                {
                    return new AuthResult() {
                        Success = false,
                        Errors = new List<String>() {
                            "Token has been used"
                        }
                    };
                }

                //==7th validation => validate the id==
                var jti = tokenVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti).Value;
                if(storedToken.JwtId != jti)
                {
                    return new AuthResult() {
                        Success = false,
                        Errors = new List<String>() {
                            "Token doesn't match"
                        }
                    };
                }

                //==update current used token==
                storedToken.IsUsed = true;
                _apiDbContext.RefreshTokens.Update(storedToken);
                await _apiDbContext.SaveChangesAsync();

                //==generate new token==
                var dbUser = await _userManager.FindByIdAsync(storedToken.UserId);
                return await GenerateJwtToken(dbUser);
            }
            catch(Exception ex)
            {
                if(ex.Message.Contains("Lifetime validation failed. The token is expired")) 
                {
                    return new AuthResult() {
                        Success = false,
                        Errors = new List<String>() {
                            "Token has expired please re-login"
                        }
                    };
                }
                else 
                {
                    return new AuthResult() {
                        Success = false,
                        Errors = new List<String>() {
                            "Something went wrong"
                        }
                    };
                }
            }
        }

        private DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            var dateTimeVal = new DateTime(1970, 1,1,0,0,0,0, DateTimeKind.Utc);
            dateTimeVal = dateTimeVal.AddSeconds(unixTimeStamp).ToUniversalTime();

            return dateTimeVal;
        }
    }    
}