using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApp.Models.DTOs.Requests
{
    public class UserLoginRequest
    {
        [Required]
        [EmailAddress]
        [Column(TypeName = "varchar(255)")]
        public string Email { get; set;}
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Password { get; set;}
    }
}