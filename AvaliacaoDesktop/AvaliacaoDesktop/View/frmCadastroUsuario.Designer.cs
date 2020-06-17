namespace AvaliacaoDesktop
{
    partial class frmCadastroUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.SobrenomeTextBox = new System.Windows.Forms.TextBox();
            this.EnderecoTextBox = new System.Windows.Forms.TextBox();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.SenhaTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmaSenhaTextBox = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.ImageUsuario_Box = new System.Windows.Forms.PictureBox();
            this.DataTp = new System.Windows.Forms.DateTimePicker();
            this.cbxAdmin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageUsuario_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirmar Senha";
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.NomeTextBox.Location = new System.Drawing.Point(161, 49);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(167, 22);
            this.NomeTextBox.TabIndex = 6;
            this.NomeTextBox.Text = "Digite seu nome...";
            this.NomeTextBox.Enter += new System.EventHandler(this.NomeTextBox_Enter);
            this.NomeTextBox.Leave += new System.EventHandler(this.NomeTextBox_Leave);
            // 
            // SobrenomeTextBox
            // 
            this.SobrenomeTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SobrenomeTextBox.Location = new System.Drawing.Point(345, 49);
            this.SobrenomeTextBox.Name = "SobrenomeTextBox";
            this.SobrenomeTextBox.Size = new System.Drawing.Size(183, 22);
            this.SobrenomeTextBox.TabIndex = 7;
            this.SobrenomeTextBox.Text = "Digite seu sobrenome...";
            this.SobrenomeTextBox.Enter += new System.EventHandler(this.SobrenomeTextBox_Enter);
            this.SobrenomeTextBox.Leave += new System.EventHandler(this.SobrenomeTextBox_Leave);
            // 
            // EnderecoTextBox
            // 
            this.EnderecoTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.EnderecoTextBox.Location = new System.Drawing.Point(161, 101);
            this.EnderecoTextBox.Name = "EnderecoTextBox";
            this.EnderecoTextBox.Size = new System.Drawing.Size(266, 22);
            this.EnderecoTextBox.TabIndex = 8;
            this.EnderecoTextBox.Text = "Digite seu endereço...";
            this.EnderecoTextBox.Enter += new System.EventHandler(this.EnderecoTextBox_Enter);
            this.EnderecoTextBox.Leave += new System.EventHandler(this.EnderecoTextBox_Leave);
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.NumeroTextBox.Location = new System.Drawing.Point(444, 101);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(83, 22);
            this.NumeroTextBox.TabIndex = 9;
            this.NumeroTextBox.Text = "Nº";
            this.NumeroTextBox.Enter += new System.EventHandler(this.NumeroTextBox_Enter);
            this.NumeroTextBox.Leave += new System.EventHandler(this.NumeroTextBox_Leave);
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.UsuarioTextBox.Location = new System.Drawing.Point(161, 225);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(167, 22);
            this.UsuarioTextBox.TabIndex = 10;
            this.UsuarioTextBox.Text = "Insira seu usuário...";
            this.UsuarioTextBox.Enter += new System.EventHandler(this.UsuarioTextBox_Enter);
            this.UsuarioTextBox.Leave += new System.EventHandler(this.UsuarioTextBox_Leave);
            // 
            // SenhaTextBox
            // 
            this.SenhaTextBox.AcceptsReturn = true;
            this.SenhaTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SenhaTextBox.Location = new System.Drawing.Point(161, 289);
            this.SenhaTextBox.Name = "SenhaTextBox";
            this.SenhaTextBox.PasswordChar = '*';
            this.SenhaTextBox.Size = new System.Drawing.Size(167, 22);
            this.SenhaTextBox.TabIndex = 11;
            this.SenhaTextBox.Text = "Insira sua senha...";
            this.SenhaTextBox.Enter += new System.EventHandler(this.SenhaTextBox_Enter);
            this.SenhaTextBox.Leave += new System.EventHandler(this.SenhaTextBox_Leave);
            // 
            // ConfirmaSenhaTextBox
            // 
            this.ConfirmaSenhaTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ConfirmaSenhaTextBox.Location = new System.Drawing.Point(161, 353);
            this.ConfirmaSenhaTextBox.Name = "ConfirmaSenhaTextBox";
            this.ConfirmaSenhaTextBox.PasswordChar = '*';
            this.ConfirmaSenhaTextBox.Size = new System.Drawing.Size(167, 22);
            this.ConfirmaSenhaTextBox.TabIndex = 12;
            this.ConfirmaSenhaTextBox.Text = "Confirme sua senha...";
            this.ConfirmaSenhaTextBox.Enter += new System.EventHandler(this.ConfirmaSenhaTextBox_Enter);
            this.ConfirmaSenhaTextBox.Leave += new System.EventHandler(this.ConfirmaSenhaTextBox_Leave);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(161, 422);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(96, 32);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(595, 188);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 30);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(692, 187);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(75, 30);
            this.btnDelet.TabIndex = 15;
            this.btnDelet.Text = "Deletar";
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // ImageUsuario_Box
            // 
            this.ImageUsuario_Box.Location = new System.Drawing.Point(595, 53);
            this.ImageUsuario_Box.Name = "ImageUsuario_Box";
            this.ImageUsuario_Box.Size = new System.Drawing.Size(170, 111);
            this.ImageUsuario_Box.TabIndex = 16;
            this.ImageUsuario_Box.TabStop = false;
            // 
            // DataTp
            // 
            this.DataTp.CustomFormat = "dd-MM-yyyy";
            this.DataTp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataTp.Location = new System.Drawing.Point(162, 164);
            this.DataTp.Name = "DataTp";
            this.DataTp.Size = new System.Drawing.Size(109, 22);
            this.DataTp.TabIndex = 17;
            this.DataTp.ValueChanged += new System.EventHandler(this.DataTextBox_ValueChanged);
            // 
            // cbxAdmin
            // 
            this.cbxAdmin.AutoSize = true;
            this.cbxAdmin.Location = new System.Drawing.Point(595, 259);
            this.cbxAdmin.Name = "cbxAdmin";
            this.cbxAdmin.Size = new System.Drawing.Size(89, 21);
            this.cbxAdmin.TabIndex = 18;
            this.cbxAdmin.Text = "É admin?";
            this.cbxAdmin.UseVisualStyleBackColor = true;
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.cbxAdmin);
            this.Controls.Add(this.DataTp);
            this.Controls.Add(this.ImageUsuario_Box);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.ConfirmaSenhaTextBox);
            this.Controls.Add(this.SenhaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.EnderecoTextBox);
            this.Controls.Add(this.SobrenomeTextBox);
            this.Controls.Add(this.NomeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo usuário - AirSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastroUsuario_FormClosing);
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            this.Enter += new System.EventHandler(this.frmCadastroUsuario_Enter);
            this.Leave += new System.EventHandler(this.frmCadastroUsuario_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.ImageUsuario_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.TextBox SobrenomeTextBox;
        private System.Windows.Forms.TextBox EnderecoTextBox;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox SenhaTextBox;
        private System.Windows.Forms.TextBox ConfirmaSenhaTextBox;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.PictureBox ImageUsuario_Box;
        private System.Windows.Forms.DateTimePicker DataTp;
        private System.Windows.Forms.CheckBox cbxAdmin;
    }
}