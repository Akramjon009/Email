namespace LoginChecker.Application.Service.Check2
{
    public interface ICheckService
    {
        Task<string> CheckAsync(string useremail, string password, string code);
    }
}
