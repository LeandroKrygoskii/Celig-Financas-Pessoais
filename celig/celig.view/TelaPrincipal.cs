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

namespace celig.view
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();

            lblUserName.Text = "Bem Vindo " + Form1.nomeUser;

        }


        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
           
        }















        // metodo para colocar um novo forms no panel central
        private Form formAtivo = null;

        private void AbrirFormFilho(Form formFilho)
        {
            if (formAtivo!=null)
                formAtivo.Close();
                formAtivo = formFilho;
                formFilho.TopLevel = false;
                formFilho.FormBorderStyle = FormBorderStyle.None;
                formFilho.Dock = DockStyle.Fill;
                PnPrincipal.Controls.Add(formFilho);
                PnPrincipal.Tag = formFilho;
                formFilho.BringToFront(); // coloca o form na frente do panel
                formFilho.Show();
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PnPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new CadastroDivida());
        }




        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Sair ?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();

        }

        private void btnDespesa_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new MostrarDespesas());
        }
    }
}
