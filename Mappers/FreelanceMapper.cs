using FreelancersAPI.DTOs.Freelance;
using FreelancersAPI.Models;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.Identity.Client;

namespace FreelancersAPI.Mappers
{
    public static class FreelanceMapper
    {
         public static FreelanceDTO     TofreelancerDTO(this FreelanceUser freelanceModel)   
         {
            return new FreelanceDTO
            {
                UserId = freelanceModel.UserId,
                Username = freelanceModel.Username,
                Email = freelanceModel.Email,
                Phonenumber = freelanceModel.Phonenumber,
                Skillsets = freelanceModel.Skillsets,   
                Hobby = freelanceModel.Hobby 
            };
         }
        public static FreelanceUser ToStockFromCreateDTO(this CreateFreelanceDTO freelanceDTO)
        {
            return new FreelanceUser
            {
                Username = freelanceDTO.Username,
                Email = freelanceDTO.Email,
                Phonenumber = freelanceDTO.Phonenumber,
                Skillsets = freelanceDTO.Skillsets,   
                Hobby = freelanceDTO.Hobby 
            };
        }

      }
}