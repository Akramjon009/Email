using LoginChecker.Application.Service.Registers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginCheker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IRegisterService _registerService;

        public RegisterController(IRegisterService register)
        {
            _registerService = register;
        }
        [HttpPost]
        public async Task<string> Register2(string username, string password)
        {
            return await _registerService.Register(username, password);
        }
    }
}
