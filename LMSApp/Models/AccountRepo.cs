using System.Collections.Generic;
using System.Linq;

namespace LMSApp.Models
{
    public class AccountRepo : IAccountRepo
    {
        private readonly LMSContext _lmsContext;

        public AccountRepo(LMSContext lmsContext)
        {
            _lmsContext = lmsContext;
        }

        public Account getUserByName(string username)
        {
            return _lmsContext.Accounts.FirstOrDefault(u => u.UserName == username);
        }
    }
}
