using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celig.Model
{
    public class GraficoCategorias
    {
        private DataBase db;
        private SQLiteCommand cmd;

        public GraficoCategorias()
        {
            db = new DataBase();
        }



        public void GrafCategorias()
        {

             cmd = new SQLiteCommand("MaioresGastosPorCategoria");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


        }


    }
}
