using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;


namespace Celig.Model
{
    public class LoginDao
    {
        private DataBase db;

        public LoginDao()
        {
            db = new DataBase();
        }

        public bool Teste(Login log)
        {
            SQLiteDataReader dr = null;
            try
            {
                string sql = "SELECT * FROM Cadastro WHERE USERNAME=@user AND SENHA=@senha";
                db.addParameter("@user", log.userName, DbType.String);
                db.addParameter("@senha", log.password, DbType.String);
                db.OpenConn();
                dr = db.ExecuteReader(sql);

                if (dr.Read())
                {
                    log.validacao = true;
                }
                return log.validacao;
            }

            catch (Exception ex)
            {
                throw new Exception("erro : " + ex.Message);
            }

            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }                
                

                db.CloseConn();
            }


        }
    }
}