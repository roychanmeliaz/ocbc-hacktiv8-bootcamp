using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApp.Models.DTOs.Requests
{
    public class TokenRequest
    {
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Token {get; set;}
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string RefreshToken {get; set;}
    }
}