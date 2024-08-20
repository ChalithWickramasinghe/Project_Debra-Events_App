using Microsoft.EntityFrameworkCore;
using DebraEventAPI.Models;
namespace DebraEventAPI.Data
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        { 

        }

        public DbSet<AddEvent> AddEvents { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddEvent>()
                .HasOne<Partner>()
                .WithMany()
                .HasForeignKey(equals => equals.PartnerId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Ticket>()
                .Property(p => p.Price).HasColumnType("decimal(18,2)");


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = @"Data Source=MSI\DEBRA_NEW;User ID=sa;Password=1234;
            Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(conn);
        }
    }
}
