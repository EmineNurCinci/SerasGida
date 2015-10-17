using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StockConfiguration:DbMigrationsConfiguration<StockContext>
    {
        public StockConfiguration ()
	   {
             AutomaticMigrationsEnabled = true;
	   }
    }
}
