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
using Celig.Model;

namespace celig.view
{
    public partial class MostrarDespesas : Form
    {
        public MostrarDespesas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if ((textBox1.Text.Length==0) && (txtNomeDespesa.Text.Length==0)) 
            {           
                dataGridView1.DataSource = ControlerDespesas.ListaDes();
            }

            if (textBox1.Text.Length != 0)
            {
                int escolha;
                List<Despesas> das = new List<Despesas>();
                escolha =  Convert.ToInt16(textBox1.Text);
                das = ControlerDespesas.ListDesById(escolha);
                dataGridView1.DataSource = das;
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MostrarDespesas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ControlerDespesas.ListaDes();

        }
    }
}
