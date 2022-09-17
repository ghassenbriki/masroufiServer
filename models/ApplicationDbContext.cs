using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace masroufiServer.models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>

    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            string ADMIN_ID = "02174cf0–9412–4cfe - afbf - 59f706d72cf6";
            string ROLE_ID = "341743f0 - asd2–42de - afbf - 59kmkkmk72cf6";

            //seed admin role
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "admin",
                NormalizedName = "admin",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            //create user
            var user = new ApplicationUser
            {
                Id = ADMIN_ID,  
                UserName = "admin",
                NormalizedUserName="admin"

            };

            //set user password
            PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = ph.HashPassword(user, "admin00");

            //seed user
            builder.Entity<ApplicationUser>().HasData(user);

            //set user role to admin
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }






    
}
