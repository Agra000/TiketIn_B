using Microsoft.EntityFrameworkCore;

namespace tiketin_b.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
            
        }

        
    }
}
