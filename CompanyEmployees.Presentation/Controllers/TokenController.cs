using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace CompanyEmployees.Presentation.Controllers;

[Route("api/token")]
[ApiController]
public class TokenController : ControllerBase
{
    private readonly IServiceManager _service;
    // GET
    public TokenController(IServiceManager service) => _service = service;
    [HttpPost("refresh")]
    public async Task<IActionResult> Refresh([FromBody] TokenDTO tokenDTO)
    {
        var tokenDTOToReturn = await _service.AuthenticationService.RefreshToken(tokenDTO);
        return Ok(tokenDTOToReturn);
    }
}