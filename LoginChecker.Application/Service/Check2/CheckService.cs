
using LoginChecker.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace LoginChecker.Application.Service.Check2
{
    public class CheckService : ICheckService
    {
        private readonly ApplicationDbContext _checkService;
        public CheckService(ApplicationDbContext context)
        {
            _checkService = context;
        }
        public async Task<string> CheckAsync(string useremail, string password, string code)
        {
            var res = await _checkService.EmailChecks.ToListAsync();
            foreach(var user in res)
            {
                if (user.Email == useremail && user.Password == password && user.Code == code) return "Welcome to our Api";
            }
            return "Something went wrong. Please try again";
        }
    }
}
