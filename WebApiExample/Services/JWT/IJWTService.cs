using IDGFAuth.Data.Entities;

namespace IDGFAuth.Services.JWT
{
    public interface IJWTService
    {
        Task<string> GenerateToken(ApplicationUser user);
        Task<ApplicationUser?> GetUserByID(string userId);
    }
}
