using Microsoft.EntityFrameworkCore;


namespace summer_chore_chart.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {


        }

        public  DbSet<BalanceTrack> BalanceTrack { get; set; }
        public  DbSet<Child> Child { get; set; }
        public  DbSet<Childtrack> Childtrack { get; set; }
        public  DbSet<Chorelist> Chorelist { get; set; }
        public  DbSet<Penalties> Penalties { get; set; }

    }
}
