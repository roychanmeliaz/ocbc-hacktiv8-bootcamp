using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// namespace TodoAppWithJWT.Models.DTOs.Requests
namespace TodoApp.Models.DTOs.Requests
{
    public class UserRegistrationDto
    {
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Username {get; set;}
        [Required]
        [EmailAddress]
        [Column(TypeName = "varchar(255)")]
        public string Email {get; set;}
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Password {get; set;}
    }
}