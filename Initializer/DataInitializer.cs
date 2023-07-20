using marsev.Models;
using Microsoft.EntityFrameworkCore;
using marsev.Enums;

namespace marsev.Initializer
{
    public static class DataInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            string password1 = BCrypt.Net.BCrypt.HashPassword("123");
            string password2 = BCrypt.Net.BCrypt.HashPassword("856575");
            modelBuilder.Entity<AppUser>().HasData(
                 new AppUser() { Id=1, UserName="admin", Password=password1, Role=Role.admin},
                 new AppUser() { Id = 2, UserName = "merve", Password = password2, Role = Role.user });
        }
    }
}
