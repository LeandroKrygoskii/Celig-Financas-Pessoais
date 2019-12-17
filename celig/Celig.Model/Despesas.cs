using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celig.Model
{
    public class Despesas
    {
        

        public Despesas()
        {

        }

        public Despesas(int id_User, int codDespesa, string descricao, double valor, int categoria, DateTime diaDespesa)
        {
            this.id_User = id_User;
            this.codDespesa = codDespesa;
            this.descricao = descricao;
            this.valor = valor;
            this.categoria = categoria;
            this.diaDespesa = diaDespesa;
        }

        public int id_User { get; set; }
        public int codDespesa { get; set; }
        public string descricao { get; set; }
        public double valor { get; set; }
        public int categoria { get; set; }
        public DateTime diaDespesa { get; set; }

    }

}
