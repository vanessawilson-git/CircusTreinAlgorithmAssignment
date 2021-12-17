using DTOAndInterfaces;
using DTOAndInterfaces.Interfaces;
using Logic.Classes;
using Logic.LogicInterfaces;

namespace Logic.LogicServices
{
    public class AccountDataHandler : IAccountDataHandler
    {
        private readonly IAccountRepo _accountRepo;

        public AccountDataHandler(IAccountRepo accountRepo)
        {
            this._accountRepo = accountRepo;
        }

        public void CreateAccount(string userName, string password, string email)
        {
            AccountDTO account = new AccountDTO();
            account.UserName = userName;
            account.Password = password;
            account.Email = email;
            _accountRepo.CreateAccount(account);
        }

        public void DeleteAccount(int userID)
        {
           _accountRepo.DeleteAccount(userID);
        }

        public Account GetAccountByEmail(string Email)
        {
            var acc = _accountRepo.GetAccountByEmail(Email);
            Account account = new Account(acc.UserId, acc.UserName, acc.Password, acc.Email);
            return account;
        }
    }
}
