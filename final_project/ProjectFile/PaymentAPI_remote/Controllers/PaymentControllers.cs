using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Payment.Data;
using Payment.Models;
// using Payment.Services;

namespace Payment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class PaymentDetailController : ControllerBase
    {
        private readonly ApiDbContext _context;
        public PaymentDetailController(ApiDbContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemData>>> GetPaymentDetails()
        {
            return await _context.Payments.ToListAsync();
        }

        [HttpGet("{paymentDetailId}")]
        public async Task<IActionResult> GetPaymentDetailsById(int paymentDetailId) 
        {
            var item = await _context.Payments.FirstOrDefaultAsync(x => x.paymentDetailId == paymentDetailId);

            if(item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePaymentDetails(ItemData data) 
        {
            if(ModelState.IsValid) 
            {
                await _context.Payments.AddAsync(data);
                await _context.SaveChangesAsync();

                // return CreatedAtAction(nameof(GetPaymentDetailsById), new {data.paymentDetailId}, data);
                return Ok("{\n  \"success\":true\n}");
            }

            return new JsonResult("Something went wrong") {StatusCode = 500};
        }

        [HttpPut("{paymentDetailId}")]
        public async Task<IActionResult> UpdatePaymentDetails(int paymentDetailId, ItemData item)
        {
            if(paymentDetailId != item.paymentDetailId)
                return BadRequest();
            
            var existItem = await _context.Payments.FirstOrDefaultAsync(x => x.paymentDetailId == paymentDetailId);

            if(existItem == null)
                return NotFound();

            existItem.cardOwnerName = item.cardOwnerName;
            existItem.cardNumber = item.cardNumber;
            existItem.expirationDate = item.expirationDate;
            existItem.securityCode = item.securityCode;
            
            // Implement the changes on the database level
            await _context.SaveChangesAsync();

            // return NoContent();
            return Ok("{\n  \"success\":true\n}");
        }

        [HttpDelete("{paymentDetailId}")]
        public async Task<IActionResult> DeletePaymentDetails(int paymentDetailId)
        {
            var existItem = await _context.Payments.FirstOrDefaultAsync(x => x.paymentDetailId == paymentDetailId);

            if(existItem == null)
                return NotFound();

            _context.Payments.Remove(existItem);
            await _context.SaveChangesAsync();

            //==respon disini==
            // return Ok(existItem);
            return Ok("{\n  \"success\":true\n}");
        }
    }
}