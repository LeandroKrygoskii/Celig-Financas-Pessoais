using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Celig.Model
{
    public class DataBase
    {

        public static SQLiteConnection conn;

         string patch = @"C:\Users\Leandro\Desktop\Celig-Financas-Pessoais\celig\Celig.Model\celigDataBase.db"; // trocar pelo endereço do arquivo do Banco de dados Sqlite
         List<SQLiteParameter> listaParameter = new List<SQLiteParameter>();

        public DataBase()
        {
            string connectionString = "Data Source=" + patch + ";Version=3";
            conn = new SQLiteConnection(connectionString);
        }


        public void OpenConn()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }



        public void CloseConn()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }



        public void addParameter(string nome, object valor, DbType tipo)
        {
            SQLiteParameter param = new SQLiteParameter(nome, valor);
            param.DbType = tipo;
            listaParameter.Add(param);
        }



        public SQLiteDataReader ExecuteReader(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            if (listaParameter != null)
            {
                foreach (SQLiteParameter parameter in listaParameter)
                {
                    cmd.Parameters.Add(parameter);
                }
            }

            SQLiteDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
        }



        public int ExecuteNoQuery(string _sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(_sql, conn);
           
            if (listaParameter != null)
            {
                foreach (SQLiteParameter parameter in listaParameter)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            int resultado = cmd.ExecuteNonQuery();
            return resultado;

        }






    }
}
