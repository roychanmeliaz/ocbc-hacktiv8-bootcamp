using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class RefreshToken
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}
        [Column(TypeName = "varchar(100)")]
        public string UserId {get; set;}
        [Column(TypeName = "varchar(100)")]
        public string Token {get; set;}
        [Column(TypeName = "varchar(100)")]
        public string JwtId {get; set;}
        [Column(TypeName = "bit")]
        public bool IsUsed {get; set;}
        [Column(TypeName = "bit")]
        public bool IsRevorked {get; set;}
        [Column(TypeName = "datetime")]
        public DateTime AddedDate {get; set;}
        [Column(TypeName = "datetime")]
        public DateTime ExpiryDate {get; set;}

        [ForeignKey(nameof(UserId))]
        public IdentityUser User {get;set;}
    }
}