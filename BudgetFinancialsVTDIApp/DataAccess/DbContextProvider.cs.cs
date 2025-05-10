using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetFinancialsVTDIApp.DataAccess
{
    public static class DbContextProvider
    {
        [ThreadStatic]
        private static BudgetFinancialsDBEntities _instance;

        public static BudgetFinancialsDBEntities Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BudgetFinancialsDBEntities();
                }
                return _instance;
            }
        }

        public static void DisposeInstance()
        {
            if (_instance != null)
            {
                _instance.Dispose();
                _instance = null;
            }
        }
    }
    public class UserService
    {
        private readonly BudgetFinancialsDBEntities _dbContext;

        public UserService(BudgetFinancialsDBEntities dbContext)
        {
            _dbContext = dbContext;
        }

        public int GetCurrentUserId(string email)
        {
            var currentUser = _dbContext.UsersTbs.FirstOrDefault(u => u.Email == email);
            return currentUser?.UserID ?? -1;
        }
    }
}
