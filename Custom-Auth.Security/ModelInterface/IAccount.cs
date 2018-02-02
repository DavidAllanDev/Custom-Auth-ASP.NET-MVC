namespace Custom_Auth.Security.ModelInterface
{
    public interface IAccount
    {
        string Password { get; set; }
        string[] Roles { get; set; }
        string UserName { get; set; }
    }
}

