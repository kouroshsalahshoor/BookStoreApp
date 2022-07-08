using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Api.Data
{
    public class ApplicationDbContext :IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);//must be first for identity

            //roles
            var name = "Users";
            var userRoleId = "a96f16bc-9986-42cf-81ab-8029778abed7";
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = userRoleId,
                    Name = name,
                    NormalizedName = name.ToUpper()
                }
                );

            name = "Admins";
            var adminRoleId = "87a98061-1c80-4e27-8676-829b98c07ad2";
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = adminRoleId,
                    Name = name,
                    NormalizedName = name.ToUpper()
                }
                );

            //users
            var hasher = new PasswordHasher<ApplicationUser>();

            name = "admin@bookstore.com";
            var adminId = "c9b4f519-fc28-4f99-99fb-be9178a64f8d";
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = adminId,
                    Email = name,
                    NormalizedEmail = name.ToUpper(),
                    UserName = name,
                    NormalizedUserName = name.ToUpper(),
                    FirstName = "Admin",
                    LastName = "Bookstore",
                    PasswordHash = hasher.HashPassword(null, "Admin_123"),
                    EmailConfirmed = true
                }
                );

            name = "user@bookstore.com";
            var userId = "74a91dac-6380-4cd6-a31d-00381a8c94a4";
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = userId,
                    Email = name,
                    NormalizedEmail = name.ToUpper(),
                    UserName = name,
                    NormalizedUserName = name.ToUpper(),
                    FirstName = "User",
                    LastName = "Bookstore",
                    PasswordHash = hasher.HashPassword(null, "User_123"),
                    EmailConfirmed = true
                }
                );

            //user role
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = adminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = userRoleId,
                    UserId = userId
                }
                );
        }
    }
}
