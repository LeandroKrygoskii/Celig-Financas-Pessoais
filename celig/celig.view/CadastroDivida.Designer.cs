namespace celig.view
{
    partial class CadastroDivida
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
            this.pnDespesaCad = new System.Windows.Forms.Panel();
            this.pbNovaCategoria = new System.Windows.Forms.PictureBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHoraAtual = new System.Windows.Forms.Label();
            this.pnDespesaCad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNovaCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDespesaCad
            // 
            this.pnDespesaCad.BackColor = System.Drawing.SystemColors.MenuText;
            this.pnDespesaCad.Controls.Add(this.pbNovaCategoria);
            this.pnDespesaCad.Controls.Add(this.dtPicker);
            this.pnDespesaCad.Controls.Add(this.label4);
            this.pnDespesaCad.Controls.Add(this.label3);
            this.pnDespesaCad.Controls.Add(this.label2);
            this.pnDespesaCad.Controls.Add(this.txtValor);
            this.pnDespesaCad.Controls.Add(this.txtDescricao);
            this.pnDespesaCad.Controls.Add(this.btnCadastrar);
            this.pnDespesaCad.Controls.Add(this.label1);
            this.pnDespesaCad.Controls.Add(this.comboBox1);
            this.pnDespesaCad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnDespesaCad.Location = new System.Drawing.Point(12, 75);
            this.pnDespesaCad.Name = "pnDespesaCad";
            this.pnDespesaCad.Size = new System.Drawing.Size(681, 373);
            this.pnDespesaCad.TabIndex = 2;
            // 
            // pbNovaCategoria
            // 
            this.pbNovaCategoria.Image = global::celig.view.Properties.Resources.icons8_plus_50;
            this.pbNovaCategoria.Location = new System.Drawing.Point(309, 234);
            this.pbNovaCategoria.Name = "pbNovaCategoria";
            this.pbNovaCategoria.Size = new System.Drawing.Size(26, 27);
            this.pbNovaCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNovaCategoria.TabIndex = 16;
            this.pbNovaCategoria.TabStop = false;
            this.pbNovaCategoria.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Location = new System.Drawing.Point(141, 164);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(376, 29);
            this.dtPicker.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Miriam Libre", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(30, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Miriam Libre", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(30, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miriam Libre", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(30, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(141, 34);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(142, 29);
            this.txtValor.TabIndex = 9;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(141, 98);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(411, 29);
            this.txtDescricao.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrar.Location = new System.Drawing.Point(141, 303);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(155, 56);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Libre", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "CATEGORIA";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "home"});
            this.comboBox1.Location = new System.Drawing.Point(141, 234);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 27);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHoraAtual
            // 
            this.lblHoraAtual.AutoSize = true;
            this.lblHoraAtual.Location = new System.Drawing.Point(31, 40);
            this.lblHoraAtual.Name = "lblHoraAtual";
            this.lblHoraAtual.Size = new System.Drawing.Size(35, 13);
            this.lblHoraAtual.TabIndex = 14;
            this.lblHoraAtual.Text = "label5";
            // 
            // CadastroDivida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.pnDespesaCad);
            this.Controls.Add(this.lblHoraAtual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "CadastroDivida";
            this.Text = "CadastroDivida";
            this.Load += new System.EventHandler(this.CadastroDivida_Load);
            this.pnDespesaCad.ResumeLayout(false);
            this.pnDespesaCad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNovaCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnDespesaCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHoraAtual;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.PictureBox pbNovaCategoria;
    }
}