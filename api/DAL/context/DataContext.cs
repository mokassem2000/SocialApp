using api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace api.DAL.context
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt):base(opt)
        {

        }
       public DbSet<AppUser> users { set; get; }
    }
}
