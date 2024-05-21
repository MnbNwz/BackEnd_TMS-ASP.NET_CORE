
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using tms.Server.Models;

namespace tms.Server.DataModel
{
    public class TMS_DB_Context : IdentityDbContext<ApplicationUser>
    {
        public TMS_DB_Context(DbContextOptions<TMS_DB_Context> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Ignore<IdentityRole>(); // Ignore the default Role table
            modelBuilder.Ignore<IdentityUserClaim<string>>(); // Ignore the default UserClaim table
            modelBuilder.Ignore<IdentityUserLogin<string>>(); // Ignore the default UserLogin table
            modelBuilder.Ignore<IdentityUserRole<string>>(); // Ignore the default UserRole table
            modelBuilder.Ignore<IdentityRoleClaim<string>>();  // Rename AspNetRoleClaims to RoleClaims
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("Jwt");



            modelBuilder.Entity<ApplicationUser>()
           .Ignore(c => c.AccessFailedCount)
           .Ignore(c => c.LockoutEnabled)
           .Ignore(c => c.NormalizedUserName)
           .Ignore(c => c.SecurityStamp)
           .Ignore(c => c.ConcurrencyStamp)
           .Ignore(c => c.PhoneNumber)
           .Ignore(c => c.PhoneNumberConfirmed)
           .Ignore(c => c.TwoFactorEnabled)
           .Ignore(c => c.NormalizedEmail)
           .Ignore(c => c.UserName)
           .Ignore(c => c.EmailConfirmed)
           .Ignore(c => c.LockoutEnd).ToTable("User").HasData(
            new ApplicationUser
            {
                Id = "1",
                FullName = "Admin Jani",
                Address = "Lahore, Pakistan",
                DateOfBirth = new DateOnly(1998, 10, 25),
                Role = 1,
                Approval = 1,
                Email = "admin@gmail.com",
                PasswordHash = HashPassword("1234")
            });

            string HashPassword(string password)
            {
                var passwordHasher = new PasswordHasher<ApplicationUser>();
                return passwordHasher.HashPassword(null, password);
            }



            //if (!adminExists)
            //{
            //    // Add the admin user if it doesn't exist
            //    modelBuilder.Entity<ApplicationUser>().HasData(
            //        new ApplicationUser
            //        {
            //            Id = "admin-id",
            //            UserName = "admin",
            //            // Other properties
            //        }
            //    );
            //}
        }
        public DbSet<ApplicationUser> Users { get; set; }
        //public DbSet<User> Users { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
    }
}
