using System.ComponentModel.DataAnnotations;

namespace LoginChecker.Domain.Models.EmailCheck
{
    public class EmailCheck
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Code { get; set; }
    }
}
