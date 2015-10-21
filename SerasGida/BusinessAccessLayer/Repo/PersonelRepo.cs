using BusinessAccessLayer.Encrypt;
using SerasGida.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessAccessLayer.Repo
{
    public class PersonelRepo:RepositoryBase<Personel>
    {
        public Personel Check(string Name, string Password)
        {
            MD5Encrypt sifrele = new MD5Encrypt();
            var sifre = sifrele.TextSifrele(Password);
            var result = this.First(x => x.UserName == Name && x.Password == Password);
            return result;

        }
    }
}
