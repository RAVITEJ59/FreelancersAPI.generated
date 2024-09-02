namespace FreelancersAPI.DTOs.Freelance
{
    public class FreelanceDTO
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phonenumber { get; set; } =string.Empty;
        public string Skillsets { get; set; } = string.Empty;
        public string Hobby { get; set; } = string.Empty;
    }
}