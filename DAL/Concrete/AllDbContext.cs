using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore; 

namespace DAL.Concrete
{
    public class AllDbContext: DbContext
    {
        public AllDbContext()
        {
        }

        public AllDbContext(DbContextOptions<AllDbContext> options): base(options)
        {

        }
        public DbSet<Flat> flats { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Invoice> invoice { get; set; }
        public DbSet<Dues> dues { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Payment> Payments { get; set; }

         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasMany(s => s.Invoice)
            .WithOne(t => t.User)
            .HasForeignKey(prop => prop.UserId);
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<User>()
            .HasMany(s => s.messages)
            .WithOne(t => t.User)
            .HasForeignKey(prop => prop.UserId);
            base.OnModelCreating(modelBuilder);



        }
       
    }
} 