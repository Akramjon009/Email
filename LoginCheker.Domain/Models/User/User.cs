using System.ComponentModel.DataAnnotations;

namespace LoginChecker.Domain.Models.User
{
    public class User
    {
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
    }
}
