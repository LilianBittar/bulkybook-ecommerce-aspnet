using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BulkyBook.Models{
    
    public class Company{

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Column("StreetAddress")]
        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        [Column("phoneNumber")]
        public string? PhoneNumber { get; set; }
    }
}