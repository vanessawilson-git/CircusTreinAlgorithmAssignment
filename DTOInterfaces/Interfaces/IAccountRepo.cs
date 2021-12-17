using System;
using System.Collections.Generic;
using System.Text;

namespace DTOAndInterfaces.Interfaces
{
    public interface IAccountRepo
    {
        void CreateAccount(AccountDTO account);
        void DeleteAccount(int userID);
        AccountDTO GetAccountByEmail(string Email);
      
    }
}
