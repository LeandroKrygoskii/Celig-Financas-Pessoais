using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Celig.Model;
using System.Windows.Forms;
using System.Data;

namespace Celig.Controller
{
    public static class ControlerDespesas
    {

        public static int CadastrarNovaCategoria(string cat)
        {
            
            DespesasDao dao = new DespesasDao();
            return dao.CadastrarNovaCategoria(cat);
            
        }


        public static List<Categorias> MostraComboBox()
        {          
            DespesasDao dao = new DespesasDao();
            return dao.mostrarComboBox();
             
        }


        public static int CadastrarDespesa(Despesas desp)
        {
            DespesasDao des = new DespesasDao();
            return des.CadastrarNovaDespesa(desp);          
        }


        public static DataTable ListaDes()
        {            
            DespesasDao dao = new DespesasDao();
            return dao.ViewListDespesas();
        }

        public static List<Despesas> ListDesById(int id)
        {           
            DespesasDao dao = new DespesasDao();
            return  dao.ViewListById(id);
        }







       
            
    }
}
