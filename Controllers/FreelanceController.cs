using FreelancersAPI.Data;
using FreelancersAPI.DTOs.Freelance;
using FreelancersAPI.Interfaces;
using FreelancersAPI.Mappers;
using FreelancersAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FreelancersAPI.Controllers
{
    [Route("api/FreelancersAPI")]
    [ApiController]
    public class FreelanceController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IFreelanceRepository _freelanceRepo;
        
        public FreelanceController(ApplicationDBContext context, IFreelanceRepository freelanceRepository )
        {
            _freelanceRepo =  freelanceRepository;
            _context = context;
        }
        
        [HttpGet] //Get All Freelance User Records
        public async Task<IActionResult> GetAllAsync()
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var freelanceUsers = await _freelanceRepo.GetAllAsync();
            var freelancerDTO =  freelanceUsers.Select(s => s.TofreelancerDTO());
            return Ok(freelanceUsers);
        }

        [HttpGet("{UserId}")] //Get Records By Id 
        public async Task<IActionResult> GetById ([FromRoute] int UserId)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var freelanceUser = await _context.FreelanceUser.FindAsync(UserId);

            if (freelanceUser == null){
                return NotFound();
            }
            return Ok (freelanceUser.TofreelancerDTO());
         }

        
         [HttpPost]  //Create New Record
        public async Task<IActionResult> CreateFreelanceUserAsync([FromBody] CreateFreelanceDTO FreelanceDTO)
        {

            var FreelanceModel = FreelanceDTO.ToStockFromCreateDTO();
            await _freelanceRepo.CreateAsync(FreelanceModel);
            return CreatedAtAction(nameof(GetById), new {userid = FreelanceModel.UserId}, FreelanceModel.TofreelancerDTO());   
        }

        [HttpPut]
        [Route("{UserId}")] //Update Existing Record
        public async Task<IActionResult> UpdateFreelancerAsync([FromRoute] int UserId, [FromBody] UpdateFreelanceDTO updateDTO)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

           var FreelancerModel = await _freelanceRepo.UpdateAsync(UserId, updateDTO);

           if (FreelancerModel == null)
           {
                return NotFound();
           } 
           return Ok(FreelancerModel.TofreelancerDTO());
         }

         [HttpDelete]
         [Route("{UserId}")] //Delete Record
         public async Task<IActionResult> DeleteFreelancerAsync([FromRoute] int UserId)
         {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
                
            var FreelancerModel = await _freelanceRepo.DeleteAsync(UserId);
            if (FreelancerModel == null)
            {
                return NotFound();
            }
            return NoContent();
         }
    }
}