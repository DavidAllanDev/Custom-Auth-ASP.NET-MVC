using System.ComponentModel.DataAnnotations;

namespace Custom_Auth.Web.Models
{
    public class Account
    {
        [Display(Name = "User")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        public string[] Roles { get; set; }
    }
}