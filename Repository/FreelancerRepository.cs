using FreelancersAPI.Data;
using FreelancersAPI.DTOs.Freelance;
using FreelancersAPI.Interfaces;
using FreelancersAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace FreelancersAPI.Repository
{
    public class FreelancerRepository : IFreelanceRepository
    {
        private readonly ApplicationDBContext _context;
        public FreelancerRepository(ApplicationDBContext Context)
        {
            _context = Context;
        }

        public async Task<FreelanceUser?> CreateAsync(FreelanceUser FreelanceModel)
        {
            await _context.FreelanceUser.AddAsync(FreelanceModel);
            await _context.SaveChangesAsync();
            return FreelanceModel;
        }

        public async Task<FreelanceUser?> DeleteAsync(int UserId)
        {
           var FreelanceModel = await _context.FreelanceUser.FirstOrDefaultAsync(x => x.UserId == UserId);
           if(FreelanceModel == null)
           {
                return null;
           }

            _context.FreelanceUser.Remove(FreelanceModel);
            await _context.SaveChangesAsync();
            return FreelanceModel;
        }

        public async Task<List<FreelanceUser>> GetAllAsync()
        {
           return await _context.FreelanceUser.ToListAsync();
        }

        public async Task<FreelanceUser?> GetByIdAsync(int UserId)
        {
            return await _context.FreelanceUser.FindAsync(UserId);
        }

        public async Task<FreelanceUser?> UpdateAsync(int UserId, UpdateFreelanceDTO updateDTO)
        {
            var existingFreelancer = await _context.FreelanceUser.FirstOrDefaultAsync(x => x.UserId == UserId);
            if (existingFreelancer == null)
            {
                return null;
            }

           existingFreelancer.Username = updateDTO.Username;
           existingFreelancer.Email = updateDTO.Email;
           existingFreelancer.Phonenumber = updateDTO.Phonenumber;
           existingFreelancer.Skillsets = updateDTO.Skillsets;
           existingFreelancer.Hobby = updateDTO.Hobby;

           await _context.SaveChangesAsync();
           return existingFreelancer;
        }
        
    }
}