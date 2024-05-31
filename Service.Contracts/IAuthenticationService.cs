using Microsoft.AspNetCore.Identity;
using Shared;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDTO userForRegistration);
        Task<bool> ValidateUser(UserForAuthenticationDTO userForAuth);
        Task<TokenDTO> CreateToken(bool populateExp);
        Task<TokenDTO> RefreshToken(TokenDTO tokenDTO);
    }
}
