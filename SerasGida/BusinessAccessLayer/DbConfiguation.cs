using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class DbConfiguation
    {
        public static void DbConfig()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StockContext, StockConfiguration>());
        }
    }
}
