using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celig.Model
{
   public class Login
    {
        

        public Login()
        {

        }

        public Login(int id_Usuaio, string userName, string password, bool validacao)
        {
            this.id_Usuaio = id_Usuaio;
            this.userName = userName;
            this.password = password;
            this.validacao = validacao;
        }


        public int id_Usuaio { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool validacao { get; set; }

        public override string ToString()
        {
            return this.id_Usuaio.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
