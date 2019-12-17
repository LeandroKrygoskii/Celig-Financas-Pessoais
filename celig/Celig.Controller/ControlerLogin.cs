using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Celig.Model;

namespace Celig.Controller
{
    public static class ControlerLogin
    {

        public static bool Acessar(Login log)
        {
            LoginDao dao = new LoginDao();
            log.validacao = dao.Teste(log);
            return log.validacao;
        }

        public static int CadastroUser(CadastroUser cad)
        {
            int resultado;
            CadastroUserDao dao = new CadastroUserDao();
            return resultado = dao.CadastroUsuario(cad);
        }


        public static Login getUserbyId(string userName)
        {
            DespesasDao des = new DespesasDao();
            return des.GetUserByID(userName);

        }


    }

   
}
