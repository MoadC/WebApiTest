using WebApi1.Entities;

namespace WebApi1.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
