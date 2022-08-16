namespace LMSApp.Models
{
    public interface IAccountRepo
    {
        Account getUserByName(string username);
    }
}
