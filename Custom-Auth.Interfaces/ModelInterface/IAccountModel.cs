namespace Custom_Auth.Interfaces.ModelInterface
{
    public interface IAccountModel
    {
        IAccount FindByUserName(string userName);
        bool IsAuthenticable(string userName, string password);
    }
}