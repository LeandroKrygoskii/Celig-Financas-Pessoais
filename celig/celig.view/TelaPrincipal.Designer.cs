namespace celig.view
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.LbDespesas = new System.Windows.Forms.Label();
            this.LbReceita = new System.Windows.Forms.Label();
            this.PnPrincipal = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGraficos = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnListDespesas = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadReceita = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDespesa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCadDespesa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEncerrar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // LbDespesas
            // 
            this.LbDespesas.AutoSize = true;
            this.LbDespesas.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.LbDespesas.Location = new System.Drawing.Point(3, 71);
            this.LbDespesas.Name = "LbDespesas";
            this.LbDespesas.Size = new System.Drawing.Size(84, 16);
            this.LbDespesas.TabIndex = 2;
            this.LbDespesas.Text = "Despesas :";
            // 
            // LbReceita
            // 
            this.LbReceita.AutoSize = true;
            this.LbReceita.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbReceita.Location = new System.Drawing.Point(3, 51);
            this.LbReceita.Name = "LbReceita";
            this.LbReceita.Size = new System.Drawing.Size(70, 16);
            this.LbReceita.TabIndex = 1;
            this.LbReceita.Text = "Receita :";
            // 
            // PnPrincipal
            // 
            this.PnPrincipal.BackColor = System.Drawing.Color.DarkGray;
            this.PnPrincipal.Controls.Add(this.label2);
            this.PnPrincipal.Controls.Add(this.pictureBox3);
            this.PnPrincipal.Controls.Add(this.panel2);
            this.PnPrincipal.Controls.Add(this.panel1);
            this.PnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PnPrincipal.Name = "PnPrincipal";
            this.PnPrincipal.Size = new System.Drawing.Size(900, 560);
            this.PnPrincipal.TabIndex = 2;
            this.PnPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PnPrincipal_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::celig.view.Properties.Resources.bagofmoney_dollBlue_ar_4399;
            this.pictureBox3.Location = new System.Drawing.Point(396, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(350, 335);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.btnGraficos);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnListDespesas);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.pnlUsuario);
            this.panel2.Controls.Add(this.btnCadReceita);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnDespesa);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnCadDespesa);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 527);
            this.panel2.TabIndex = 2;
            // 
            // btnGraficos
            // 
            this.btnGraficos.FlatAppearance.BorderSize = 0;
            this.btnGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGraficos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGraficos.Image = global::celig.view.Properties.Resources.icons8_combo_chart_24;
            this.btnGraficos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraficos.Location = new System.Drawing.Point(-3, 306);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(200, 44);
            this.btnGraficos.TabIndex = 6;
            this.btnGraficos.Text = "Gráficos";
            this.btnGraficos.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 475);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 44);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnListDespesas
            // 
            this.btnListDespesas.FlatAppearance.BorderSize = 0;
            this.btnListDespesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListDespesas.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnListDespesas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListDespesas.Image = global::celig.view.Properties.Resources.icons8_money_24;
            this.btnListDespesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListDespesas.Location = new System.Drawing.Point(-3, 256);
            this.btnListDespesas.Name = "btnListDespesas";
            this.btnListDespesas.Size = new System.Drawing.Size(200, 44);
            this.btnListDespesas.TabIndex = 4;
            this.btnListDespesas.Text = "Minhas Receitas";
            this.btnListDespesas.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(350, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "Minhas Receitas";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.pnlUsuario.Controls.Add(this.lblUserName);
            this.pnlUsuario.Controls.Add(this.label1);
            this.pnlUsuario.Controls.Add(this.pictureBox1);
            this.pnlUsuario.Controls.Add(this.LbReceita);
            this.pnlUsuario.Controls.Add(this.LbDespesas);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(200, 100);
            this.pnlUsuario.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(42, 18);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 20);
            this.lblUserName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(79, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::celig.view.Properties.Resources.icons8_user_30;
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadReceita
            // 
            this.btnCadReceita.FlatAppearance.BorderSize = 0;
            this.btnCadReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadReceita.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCadReceita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadReceita.Image = global::celig.view.Properties.Resources.icons8_plus_24;
            this.btnCadReceita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadReceita.Location = new System.Drawing.Point(-3, 206);
            this.btnCadReceita.Name = "btnCadReceita";
            this.btnCadReceita.Size = new System.Drawing.Size(200, 44);
            this.btnCadReceita.TabIndex = 2;
            this.btnCadReceita.Text = "Nova Receita";
            this.btnCadReceita.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(350, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Nova Receita";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnDespesa
            // 
            this.btnDespesa.FlatAppearance.BorderSize = 0;
            this.btnDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespesa.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDespesa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDespesa.Image = global::celig.view.Properties.Resources.icons8_wallet_24;
            this.btnDespesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDespesa.Location = new System.Drawing.Point(0, 156);
            this.btnDespesa.Name = "btnDespesa";
            this.btnDespesa.Size = new System.Drawing.Size(200, 44);
            this.btnDespesa.TabIndex = 1;
            this.btnDespesa.Text = "Minhas Despesas";
            this.btnDespesa.UseVisualStyleBackColor = true;
            this.btnDespesa.Click += new System.EventHandler(this.btnDespesa_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(350, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Minhas Despesas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCadDespesa
            // 
            this.btnCadDespesa.FlatAppearance.BorderSize = 0;
            this.btnCadDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadDespesa.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadDespesa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadDespesa.Image = global::celig.view.Properties.Resources.icons8_plus_24;
            this.btnCadDespesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadDespesa.Location = new System.Drawing.Point(0, 106);
            this.btnCadDespesa.Name = "btnCadDespesa";
            this.btnCadDespesa.Size = new System.Drawing.Size(200, 44);
            this.btnCadDespesa.TabIndex = 0;
            this.btnCadDespesa.Text = "Nova Despesa";
            this.btnCadDespesa.UseVisualStyleBackColor = true;
            this.btnCadDespesa.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(350, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nova Despesa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnEncerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 33);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::celig.view.Properties.Resources.icons8_minimize_window_32;
            this.pictureBox4.Location = new System.Drawing.Point(769, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::celig.view.Properties.Resources.icons8_maximize_button_26;
            this.pictureBox2.Location = new System.Drawing.Point(815, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Image = global::celig.view.Properties.Resources.icons8_close_window_32;
            this.btnEncerrar.Location = new System.Drawing.Point(851, 0);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(46, 38);
            this.btnEncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEncerrar.TabIndex = 0;
            this.btnEncerrar.TabStop = false;
            this.btnEncerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.PnPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.PnPrincipal.ResumeLayout(false);
            this.PnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnPrincipal;
        private System.Windows.Forms.Label LbReceita;
        private System.Windows.Forms.Label LbDespesas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox btnEncerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnListDespesas;
        private System.Windows.Forms.Button btnCadReceita;
        private System.Windows.Forms.Button btnDespesa;
        private System.Windows.Forms.Button btnCadDespesa;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnGraficos;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}