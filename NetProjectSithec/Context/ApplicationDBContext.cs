using Microsoft.EntityFrameworkCore;
using NetProjectSithec.Models;

namespace NetProjectSithec.Context
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Human> Humans { get; set; }
    }
}
