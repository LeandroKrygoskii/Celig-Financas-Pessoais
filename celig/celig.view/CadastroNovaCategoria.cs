using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celig.Controller;

namespace celig.view
{
    public partial class CadastroNovaCategoria : Form
    {
        public CadastroNovaCategoria()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int resultado;
            string novo = txtCat.Text;

            if (novo.Length != 0)
            {
                resultado = ControlerDespesas.CadastrarNovaCategoria(novo);
                if (resultado != 0)
                {
                    MessageBox.Show("Cadastro Bem sucedido");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao Cadastrar");
                }
            }
            else
            {
                MessageBox.Show("Digite uma categoria");
            }
        }




    }
    
}
