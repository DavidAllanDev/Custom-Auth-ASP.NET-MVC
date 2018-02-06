using System.ComponentModel.DataAnnotations;
using Custom_Auth.Interfaces.ModelInterface;

namespace Custom_Auth.Domain.Model
{
    public class Account : IAccount
    {
        [Display(Name = "User")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        public string[] Roles { get; set; }
    }
}
