namespace LoginChecker.Application.Service.Registers
{
    public interface IRegisterService
    {
        Task<string> Register (string useremail, string password);
        Task<bool> DoesExist (string useremail);

    }
}
