using System.ComponentModel.DataAnnotations;
using Custom_Auth.Security.ModelInterface;

namespace Custom_Auth.Web.Models
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