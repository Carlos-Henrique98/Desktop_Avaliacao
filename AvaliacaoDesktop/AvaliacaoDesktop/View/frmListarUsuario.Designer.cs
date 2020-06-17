namespace AvaliacaoDesktop
{
    partial class frmListarUsuario
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.VoltarBtn = new System.Windows.Forms.Button();
            this.DeletaBtn = new System.Windows.Forms.Button();
            this.EditarBtn = new System.Windows.Forms.Button();
            this.NovoBtn = new System.Windows.Forms.Button();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxSobrenome = new System.Windows.Forms.TextBox();
            this.tbxEndereco = new System.Windows.Forms.TextBox();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.tbxConfirSenha = new System.Windows.Forms.TextBox();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.AlterarBtn = new System.Windows.Forms.Button();
            this.DeletarBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.NomeTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobrenomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.dgvListarUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Usuário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Senha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(498, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Confirmar Senha";
            // 
            // VoltarBtn
            // 
            this.VoltarBtn.Location = new System.Drawing.Point(430, 537);
            this.VoltarBtn.Name = "VoltarBtn";
            this.VoltarBtn.Size = new System.Drawing.Size(75, 37);
            this.VoltarBtn.TabIndex = 8;
            this.VoltarBtn.Text = "Voltar";
            this.VoltarBtn.UseVisualStyleBackColor = true;
            this.VoltarBtn.Click += new System.EventHandler(this.VoltarBtn_Click);
            // 
            // DeletaBtn
            // 
            this.DeletaBtn.Location = new System.Drawing.Point(742, 537);
            this.DeletaBtn.Name = "DeletaBtn";
            this.DeletaBtn.Size = new System.Drawing.Size(75, 37);
            this.DeletaBtn.TabIndex = 9;
            this.DeletaBtn.Text = "Deletar";
            this.DeletaBtn.UseVisualStyleBackColor = true;
            this.DeletaBtn.Click += new System.EventHandler(this.DeletaBtn_Click);
            // 
            // EditarBtn
            // 
            this.EditarBtn.Location = new System.Drawing.Point(649, 537);
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.Size = new System.Drawing.Size(75, 37);
            this.EditarBtn.TabIndex = 10;
            this.EditarBtn.Text = "Editar";
            this.EditarBtn.UseVisualStyleBackColor = true;
            this.EditarBtn.Click += new System.EventHandler(this.EditarBtn_Click);
            // 
            // NovoBtn
            // 
            this.NovoBtn.Location = new System.Drawing.Point(556, 537);
            this.NovoBtn.Name = "NovoBtn";
            this.NovoBtn.Size = new System.Drawing.Size(75, 37);
            this.NovoBtn.TabIndex = 11;
            this.NovoBtn.Text = "Novo";
            this.NovoBtn.UseVisualStyleBackColor = true;
            this.NovoBtn.Click += new System.EventHandler(this.NovoBtn_Click);
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(628, 191);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(190, 22);
            this.tbxNome.TabIndex = 12;
            // 
            // tbxSobrenome
            // 
            this.tbxSobrenome.Location = new System.Drawing.Point(628, 226);
            this.tbxSobrenome.Name = "tbxSobrenome";
            this.tbxSobrenome.Size = new System.Drawing.Size(190, 22);
            this.tbxSobrenome.TabIndex = 13;
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.Location = new System.Drawing.Point(628, 261);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(190, 22);
            this.tbxEndereco.TabIndex = 14;
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(628, 331);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(190, 22);
            this.tbxNumero.TabIndex = 16;
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(628, 366);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(190, 22);
            this.tbxUsuario.TabIndex = 17;
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(628, 401);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(190, 22);
            this.tbxSenha.TabIndex = 18;
            // 
            // tbxConfirSenha
            // 
            this.tbxConfirSenha.Location = new System.Drawing.Point(628, 436);
            this.tbxConfirSenha.Name = "tbxConfirSenha";
            this.tbxConfirSenha.Size = new System.Drawing.Size(190, 22);
            this.tbxConfirSenha.TabIndex = 19;
            // 
            // pcbImage
            // 
            this.pcbImage.BackgroundImage = global::AvaliacaoDesktop.Properties.Resources.Air;
            this.pcbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbImage.Location = new System.Drawing.Point(649, 33);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(156, 90);
            this.pcbImage.TabIndex = 20;
            this.pcbImage.TabStop = false;
            // 
            // AlterarBtn
            // 
            this.AlterarBtn.Location = new System.Drawing.Point(649, 137);
            this.AlterarBtn.Name = "AlterarBtn";
            this.AlterarBtn.Size = new System.Drawing.Size(75, 34);
            this.AlterarBtn.TabIndex = 21;
            this.AlterarBtn.Text = "Alterar";
            this.AlterarBtn.UseVisualStyleBackColor = true;
            // 
            // DeletarBtn
            // 
            this.DeletarBtn.Location = new System.Drawing.Point(730, 137);
            this.DeletarBtn.Name = "DeletarBtn";
            this.DeletarBtn.Size = new System.Drawing.Size(75, 34);
            this.DeletarBtn.TabIndex = 22;
            this.DeletarBtn.Text = "Deletar";
            this.DeletarBtn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(666, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Dados Pessoais";
            // 
            // NomeTxt
            // 
            this.NomeTxt.Location = new System.Drawing.Point(121, 537);
            this.NomeTxt.Name = "NomeTxt";
            this.NomeTxt.Size = new System.Drawing.Size(216, 22);
            this.NomeTxt.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 537);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Nome:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripMenuItem,
            this.nomeToolStripMenuItem,
            this.sobrenomeToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iDToolStripMenuItem
            // 
            this.iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            this.iDToolStripMenuItem.Size = new System.Drawing.Size(38, 24);
            this.iDToolStripMenuItem.Text = "ID";
            // 
            // nomeToolStripMenuItem
            // 
            this.nomeToolStripMenuItem.Name = "nomeToolStripMenuItem";
            this.nomeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.nomeToolStripMenuItem.Text = "Nome";
            // 
            // sobrenomeToolStripMenuItem
            // 
            this.sobrenomeToolStripMenuItem.Name = "sobrenomeToolStripMenuItem";
            this.sobrenomeToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.sobrenomeToolStripMenuItem.Text = "Sobrenome";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Location = new System.Drawing.Point(628, 296);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(190, 22);
            this.dtpNascimento.TabIndex = 28;
            // 
            // dgvListarUsuario
            // 
            this.dgvListarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarUsuario.Location = new System.Drawing.Point(0, 31);
            this.dgvListarUsuario.Name = "dgvListarUsuario";
            this.dgvListarUsuario.RowHeadersWidth = 51;
            this.dgvListarUsuario.RowTemplate.Height = 24;
            this.dgvListarUsuario.Size = new System.Drawing.Size(470, 458);
            this.dgvListarUsuario.TabIndex = 29;
            this.dgvListarUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarUsuario_CellClick);
            this.dgvListarUsuario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarUsuario_CellMouseClick);
            // 
            // frmListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 601);
            this.Controls.Add(this.dgvListarUsuario);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NomeTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DeletarBtn);
            this.Controls.Add(this.AlterarBtn);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.tbxConfirSenha);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.tbxNumero);
            this.Controls.Add(this.tbxEndereco);
            this.Controls.Add(this.tbxSobrenome);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.NovoBtn);
            this.Controls.Add(this.EditarBtn);
            this.Controls.Add(this.DeletaBtn);
            this.Controls.Add(this.VoltarBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmListarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar usuários - AirSystem";
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarUsuario)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button VoltarBtn;
        private System.Windows.Forms.Button DeletaBtn;
        private System.Windows.Forms.Button EditarBtn;
        private System.Windows.Forms.Button NovoBtn;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxSobrenome;
        private System.Windows.Forms.TextBox tbxEndereco;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.TextBox tbxConfirSenha;
        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.Button AlterarBtn;
        private System.Windows.Forms.Button DeletarBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NomeTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobrenomeToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.DataGridView dgvListarUsuario;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}