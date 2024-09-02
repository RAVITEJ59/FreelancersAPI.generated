using FreelancersAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FreelancersAPI.Data
{
    public class ApplicationDBContext : DbContext    
    {

        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<FreelanceUser> FreelanceUser{get; set;}
    }
}