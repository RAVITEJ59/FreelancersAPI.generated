using System.ComponentModel.DataAnnotations;

namespace FreelancersAPI.DTOs.Freelance
{
    public class CreateFreelanceDTO
    {
        [Required]
        [MinLength(5, ErrorMessage ="Username must be 5 Characters")]
        [MaxLength(100, ErrorMessage ="Username cannot be over 100 Characters")]
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phonenumber { get; set; } =string.Empty;
        public string Skillsets { get; set; } = string.Empty;
        
        [MaxLength(100, ErrorMessage ="Username cannot be over 100 Characters")]
        public string Hobby { get; set; } = string.Empty;
    }
}