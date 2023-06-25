using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccountModel
    {
        private KShopDBContext context = null;
        public AccountModel()
        {
            context = new KShopDBContext();
        }
        public bool Login(string username, string password)
        {
            var parameters = new object[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };

            var res = context.Database.SqlQuery<bool>("Sp_Account_Login @username,@password", parameters).SingleOrDefault();
            return res;
        }

    }
}
