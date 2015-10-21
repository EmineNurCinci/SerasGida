using SerasGida.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StockConfiguration : DbMigrationsConfiguration<StockContext>
    {
        public StockConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StockContext context)
        {
            context.Personeller.AddOrUpdate(
                new Personel
                {
                    Ad = "Emine",
                    Mail = "eminenurcnc@gmail.com",
                    Soyad = "Cinci",
                    Tur = "Nrmal"

                }
                );
        }
    }
 }
