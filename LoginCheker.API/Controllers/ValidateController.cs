using LoginChecker.Application.Service.Check2;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginCheker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidateController : ControllerBase
    {
        private readonly ICheckService _checkService;

        public ValidateController(ICheckService checkService)
        {
            _checkService = checkService;
        }
        [HttpPost]
        public async Task<string> Validate(string useremail, string password, string code)
        {
            return await _checkService.CheckAsync(useremail, password, code);
        }
    }
}
