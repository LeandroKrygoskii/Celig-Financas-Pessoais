using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celig.Model;
using Celig.Controller;
using System.Data.SQLite;


namespace celig.view
{
    public partial class CadastroDivida : Form
    {
        

        public CadastroDivida()
        {
            InitializeComponent();
            this.timer1.Start();
           
        }

        private void CadastroDivida_Load(object sender, EventArgs e)
        {
            //List<string> categorias = new List<string>(); não precisa criar uma nova lista em cada camada
            //categorias = ControlerDespesas.MostraComboBox();
            
            
            comboBox1.DataSource = ControlerDespesas.MostraComboBox();
           
        }











       


        private void button1_Click(object sender, EventArgs e)
        {
            int resultado;         
            Despesas objdes = new Despesas();
            
            if ((txtDescricao.Text.Length !=0) && (txtValor.Text.Length != 0) && (comboBox1.Text.Length != 0))
            {
                objdes.valor = Convert.ToDouble(txtValor.Text);
                objdes.descricao = txtDescricao.Text;
                Categorias cat = (Categorias)comboBox1.SelectedItem;
                objdes.categoria = cat.idDesc;
                objdes.id_User = Form1.User.id_Usuaio;
                objdes.diaDespesa = dtPicker.Value;
                resultado = ControlerDespesas.CadastrarDespesa(objdes);
                if (resultado != 0)
                {
                    MessageBox.Show("Cadastro Bem sucedido");
                }
            }
            else
            {
                MessageBox.Show("Você deve preencher todos os campos");
            }


            
            
            
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CadastroNovaCategoria TelaCadCategoria = new CadastroNovaCategoria();
            TelaCadCategoria.ShowDialog();

        }




    }
}
