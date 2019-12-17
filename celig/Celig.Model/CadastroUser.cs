using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celig.Model
{
    public class CadastroUser
    {
        public CadastroUser(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public CadastroUser()
        {

        }
        public string userName { get; set; }
        public string password { get; set; }


    }
}
