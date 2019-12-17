using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;


namespace Celig.Model
{
   public class DespesasDao
    {
        private DataBase db;



        public DespesasDao()
        {
            db = new DataBase();
        }


        public int CadastrarNovaCategoria(string cat)
        {
            
            int resultado = 0;
            string query = "INSERT INTO Categoria (descricao) VALUES (@desc)";
            try
            {
                db.OpenConn();
                db.addParameter("@desc", cat, DbType.String);
                return resultado = db.ExecuteNoQuery(query);

            }
            catch (Exception ex)
            {

                throw new Exception("erro : "+ ex.Message);
            }
            finally
            {
                db.CloseConn();
            }
        }


        public int CadastrarNovaDespesa(Despesas des)
        {
           
            int resultado = 0;
            string query = "INSERT INTO Despesas (id_User,valor,descricao,idCat,Data) VALUES (@user,@desc,@valor,@categ,@date)";
            try
            {
                db.OpenConn();
                db.addParameter("@user", des.id_User, DbType.Int16);
                db.addParameter("@valor", des.valor, DbType.Double);
                db.addParameter("@desc", des.descricao, DbType.String);              
                db.addParameter("@categ", des.categoria, DbType.Int16);
                db.addParameter("@date", des.diaDespesa, DbType.DateTime);
                return resultado = db.ExecuteNoQuery(query);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                db.CloseConn();
            }

        }



        public DataTable ViewListDespesas()
        {

            string query = "SELECT idDespesas,valor,descricao,Data FROM Despesas ;";
            SQLiteDataReader dr = null;
            SQLiteCommand cmd;
            SQLiteConnection conn = DataBase.conn;
            List<Despesas> listaDespesas = new List<Despesas>();
           
            try
            {
                db.OpenConn();               
                //db.addParameter("@id", DbType.Int16);               
                conn = new SQLiteConnection(conn);
                cmd = new SQLiteCommand(query, conn);

                SQLiteDataAdapter Da = new SQLiteDataAdapter();
                Da.SelectCommand = cmd;
                   Despesas des = new Despesas();
                   DataTable Dt = new DataTable();                
                Da.Fill(Dt);
                return Dt;

                //if (dr.Read()) {

                //    //int.TryParse((dr["idDespesas"]).ToString(), out resultado);
                //    //double.TryParse((dr["idDespesas"), des.codDespesa);
                //    //string.TryParse((dr["idDespesas"), des.codDespesa);
                //    //int.TryParse((dr["idDespesas"), des.codDespesa);
                //    //int.TryParse((dr["idDespesas"), des.codDespesa);
                //    //int.TryParse((dr["idDespesas"), des.codDespesa);
                //    ///////----/////////----///////
                //    des.codDespesa = dr[0].ToString();
                //    des.valor = Convert.ToDouble(dr["valor"]);
                //    des.descricao = Convert.ToString(dr["descricao"]);
                //    des.categoria = Convert.ToInt16(dr["idCat"]);
                //    des.diaDespesa = Convert.ToDateTime(dr["Data"]);
                //    des.id_User = Convert.ToInt16(dr["id_User"]);

                //    //des.codDespesa = Convert.ToInt32(dr["idDespesas"]);
                //    //des.valor = Convert.ToDouble(dr["valor"]);
                //    //des.descricao = Convert.ToString(dr["descricao"]);
                //    //des.categoria = Convert.ToInt16(dr["idCat"]);
                //    //des.diaDespesa = Convert.ToDateTime(dr["Data"]);
                //    //des.id_User = Convert.ToInt16(dr["id_User"]);
                //    listaDespesas.Add(des);


                //}
                //return listaDespesas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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



        public List<Despesas> ViewListById(int idDes)
        {
            string query = "SELECT * FROM Despesas WHERE idDespesas = @idDes";
            SQLiteDataReader dr = null;

            List<Despesas> listaDespesas = new List<Despesas>();
            try
            {
                db.OpenConn();
                db.addParameter("@idDes", idDes, DbType.Int16);
                dr = db.ExecuteReader(query);
                Despesas des = new Despesas();
                if (dr.Read())
                {
                    
                    des.codDespesa = Convert.ToInt32(dr["idDespesas"]);
                    des.valor = Convert.ToDouble(dr["valor"]);
                    des.descricao = Convert.ToString(dr["descricao"]);
                    des.categoria = Convert.ToInt16(dr["idCat"]);
                    des.diaDespesa = Convert.ToDateTime(dr["Data"]);
                    des.id_User = Convert.ToInt16(dr["id_User"]);
                    listaDespesas.Add(des);
                }
                return listaDespesas;
            }
            catch (Exception)
            {
                throw new Exception("Erro Db");
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


        public Login GetUserByID(string userName)
        {
            SQLiteDataReader dr = null;
            try
            {
                string query = "SELECT * FROM Cadastro WHERE USERNAME =@user";
                db.addParameter("@user", userName, DbType.String);
                db.OpenConn();
                db.ExecuteNoQuery(query);
                dr = db.ExecuteReader(query);
                Login log = new Login();
                if (dr.Read())
                {
                   
                    log.id_Usuaio = Convert.ToInt16(dr["id_User"]);
                    log.userName = Convert.ToString(dr["USERNAME"]);
                   
                }
                return log;
            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message);
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





        public List<Categorias> mostrarComboBox()
        {
            //txtCat.Visible = txtCat.Enabled= false;
            SQLiteDataReader dr = null;
            string query = "SELECT * FROM Categoria";
            List<Categorias> nova = new List<Categorias>();

            
            try
            {
                db.OpenConn();
                dr = db.ExecuteReader(query);

                while (dr.Read())
                {
                    Categorias des = new Categorias();
                    des.descricao = Convert.ToString(dr["descricao"]);
                    des.idDesc = Convert.ToInt16(dr["idCat"]);
                    nova.Add(des);                            
                }
              
                return nova;


            }
            catch (Exception)
            {

                throw new Exception("Escolha uma categoria");
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
