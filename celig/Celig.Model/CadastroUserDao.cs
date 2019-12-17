using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Celig.Model
{
    public class CadastroUserDao
    {
        private DataBase db;

        public CadastroUserDao()
        {
            //instancia a classe DataBase
            db = new DataBase();
        }

        public int CadastroUsuario(CadastroUser dados)
        {
            int resultado;
            string query = "INSERT INTO Login (userName, password)" + "VALUES (@user, @pass)";

            try
            {
                db.OpenConn();
                db.addParameter("@user", dados.userName, DbType.String);
                db.addParameter("@pass", dados.password, DbType.String);
                resultado = db.ExecuteNoQuery(query);
                return resultado;
            }
            
            catch (Exception)
            {

                throw new Exception ("Erro no Banco de Dados");
            }
            finally
            {
                db.CloseConn();
            }


        }


    }
}
