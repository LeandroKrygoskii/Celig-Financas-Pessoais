using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celig.Model
{
    public class Categorias
    {
        public Categorias(string descricao, int idDesc)
        {
            this.descricao = descricao;
            this.idDesc = idDesc;
        }

        public Categorias()
        {

        }

        public int idDesc { get; set; }
        public string descricao { get; set; }


        public override string ToString()
        {
            return this.descricao;

        }
    }
}
