using Logic.Classes;

namespace Logic.LogicInterfaces
{
    public interface IAccountDataHandler
    {
        void CreateAccount(string userName, string password, string email);
        void DeleteAccount(int userID);

        Account GetAccountByEmail(string Email);
    }
}
