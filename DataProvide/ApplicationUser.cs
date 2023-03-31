using Microsoft.AspNetCore.Identity;

namespace DbLabBackend.DataProvide
{
    public class ApplicationUser : IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }

    }
}