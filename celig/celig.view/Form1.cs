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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblmsg.Visible = false;
        }

        public static Login User;
        public static string nomeUser;
       

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.userName = TxtNome.Text;
            log.password = TxtSenha.Text;
            nomeUser = TxtNome.Text;

            ControlerLogin.Acessar(log);

            if ((TxtNome.Text.Length != 0) && (TxtSenha.Text.Length != 0))
            {
                if (log.validacao == true)
                {                   
                    
                        TelaPrincipal telaPrincipal = new TelaPrincipal();
                        User = ControlerLogin.getUserbyId(TxtNome.Text);                     
                        telaPrincipal.Show();
                        telaPrincipal.FormClosed += Logout;
                        this.Hide();
                        
                                     
                }
                else
                {
                   msgErro("Usuario ou senha não existem");
                    
                }
            }
            else
            {
                 msgErro("Complete todos os campos");
            }
            

        }

        private void msgErro(string msg)
        {
            lblmsg.Text = "    " + msg;
            lblmsg.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            lblmsg.Visible = false;
            this.Show();
            TxtNome.Focus();
        }

    }

    }

