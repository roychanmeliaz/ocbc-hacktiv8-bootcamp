// namespace TodoApp.Models
// {
//     public class ItemData
//     {
//         public int Id { get; set;}
//         public string Title { get; set;}
//         public string Description { get; set;}
//         public bool Done { get; set;}
//     }
// }

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApp.Models
{
    public class ItemData
    {
        // [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // public int Id { get; set; }

        // [Required]
        // [Column(TypeName = "varchar(100)")]
        // public string Title { get; set; }

        // [Required]
        // [Column(TypeName = "varchar(100)")]
        // public string Description { get; set; }

        // [Required]
        // // [Column(TypeName = "boolean")]
        // [Column(TypeName = "bit")]
        // // [DefaultValue(false)]
        // public bool Done { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int paymentDetailId { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string cardOwnerName { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string cardNumber { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string expirationDate { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string securityCode { get; set; }
 
    }
}