namespace LoginChecker.Application.Service.Logins
{
    public interface ILoginService
    {
        Task<bool> IsCorrect(string useremail, string password);
        Task<string> SendMessage(string useremail, string password);
    }
}
