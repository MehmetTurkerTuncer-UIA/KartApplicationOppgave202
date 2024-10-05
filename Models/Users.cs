using System.ComponentModel.DataAnnotations;

namespace KartApplication.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
                      
        public string PhoneNumber { get; set; } = string.Empty; 
        
        public string Adresse { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
