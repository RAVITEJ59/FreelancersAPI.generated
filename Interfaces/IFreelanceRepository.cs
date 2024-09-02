using FreelancersAPI.DTOs.Freelance;
using FreelancersAPI.Models;

namespace FreelancersAPI.Interfaces
{
    public interface IFreelanceRepository
    {
        Task <List<FreelanceUser>> GetAllAsync();
        Task <FreelanceUser?> GetByIdAsync(int UserId); //FirstOrDefault
        Task <FreelanceUser?> CreateAsync(FreelanceUser FreelanceModel);
        Task <FreelanceUser?> UpdateAsync(int UserId, UpdateFreelanceDTO updateDTO);
        Task <FreelanceUser?> DeleteAsync(int UserId);
    }
}