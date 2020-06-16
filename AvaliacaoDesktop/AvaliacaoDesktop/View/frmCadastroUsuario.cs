using AvaliacaoDesktop.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoDesktop
{
    public partial class frmCadastroUsuario : Form
    {
        private Usuario usuario = null;
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
           if(frmLogin.idioma == 0)
            {
                MessageBox.Show("Inglês");
            }
           else
            {
                MessageBox.Show("Português");
            }
        }

        private void frmCadastroUsuario_Enter(object sender, EventArgs e)
        {
            TextBox tbx = sender as TextBox;
            if(tbx != null)
            {
                ImageUsuario_Box.Location = new Point(tbx.Location.X - 5, tbx.Location.Y - 5);
                ImageUsuario_Box.Size = new Size(tbx.Size.Width + 10, tbx.Size.Height + 10);
                ImageUsuario_Box.Visible = true;
            }
            else
            {
                DateTimePicker dtp = sender as DateTimePicker;

                if(dtp != null)
                {
                    ImageUsuario_Box.Location = new Point(dtp.Location.X - 5, dtp.Location.Y - 5);
                    ImageUsuario_Box.Size = new Size(dtp.Size.Width + 10, dtp.Size.Height + 10);
                    ImageUsuario_Box.Visible = true;
                }
            }
                
        }

        private void frmCadastroUsuario_Leave(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                ImageUsuario_Box.Image = Image.FromFile(ofd.FileName);
            }

        }

        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(!Utils.temCamposVazio(this))
            {
                Usuario usuario = new Usuario
                {
                    nome = NomeTextBox.Text,
                    sobrenome = SobrenomeTextBox.Text,
                    usuario = UsuarioTextBox.Text,
                    senha = SenhaTextBox.Text,
                    confirmaSenha = ConfirmaSenhaTextBox.Text
                };
                UsuarioRepository repository = new UsuarioRepository();
                repository.adicionar(usuario);

                MessageBox.Show("Dados Salvos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
                else if(NomeTextBox.Text.Trim().Length == 0 || SobrenomeTextBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Campos não preenchidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(UsuarioTextBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Campos não preenchidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(SenhaTextBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Campos não preenchidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            
        }

        private bool SenhaTextBox_TextChanged(string senha)
        {
            if(senha.Length >= 8)
            {
                string pattern = "[a-z]{1,}";

                if(Regex.IsMatch(senha,pattern))
                {
                    pattern = "[A-Z]{1,}";

                    if(Regex.IsMatch(senha,pattern))
                    {
                        pattern = "[0,9]{1,}";
                        if(Regex.IsMatch(senha,pattern))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        //Na edição dos campos, trabalhar com place holder conforme apresentado na tela acima.
        private void NomeTextBox_Enter(object sender, EventArgs e)
        {
            if (NomeTextBox.Text == "Digite seu nome...")
            {
                NomeTextBox.Text = "";
                NomeTextBox.ForeColor = Color.Black;

            }
        }

        private void NomeTextBox_Leave(object sender, EventArgs e)
        {
            if(NomeTextBox.Text == "")
            {
                NomeTextBox.Text = "Digite o seu nome...";
                NomeTextBox.ForeColor = Color.Silver;
                 
            }
        }

        private void SobrenomeTextBox_Enter(object sender, EventArgs e)
        {
            if (SobrenomeTextBox.Text == "Digite seu sobrenome...")
            {
                SobrenomeTextBox.Text = "";
                SobrenomeTextBox.ForeColor = Color.Black;
            }
        }

        private void SobrenomeTextBox_Leave(object sender, EventArgs e)
        {
            if(SobrenomeTextBox.Text == "")
            {
                SobrenomeTextBox.Text = "Digite seu sobrenome...";
                SobrenomeTextBox.ForeColor = Color.Silver;
            }
        }

        private void EnderecoTextBox_Enter(object sender, EventArgs e)
        {
            if(EnderecoTextBox.Text == "Digite seu endereço...")
            {
                EnderecoTextBox.Text = "";
                EnderecoTextBox.ForeColor = Color.Black;

            }
        }

        private void EnderecoTextBox_Leave(object sender, EventArgs e)
        {
            if(EnderecoTextBox.Text == "")
            {
                EnderecoTextBox.Text = "Digite seu endereco...";
                EnderecoTextBox.ForeColor = Color.Silver;
            }
        }

        private void NumeroTextBox_Enter(object sender, EventArgs e)
        {
            if(NumeroTextBox.Text == "Nº")
            {
                NumeroTextBox.Text = "";
                NumeroTextBox.ForeColor = Color.Black;
            }
        }

        private void NumeroTextBox_Leave(object sender, EventArgs e)
        {
            if(NumeroTextBox.Text == "")
            {
                NumeroTextBox.Text = "Nº";
                NumeroTextBox.ForeColor = Color.Silver;
            }
        }

        private void UsuarioTextBox_Enter(object sender, EventArgs e)
        {
            if(UsuarioTextBox.Text == "Insira seu usuário...")
            {
                UsuarioTextBox.Text = "";
                UsuarioTextBox.ForeColor = Color.Black;
            }
        }

        private void UsuarioTextBox_Leave(object sender, EventArgs e)
        {
            if(UsuarioTextBox.Text == "")
            {
                UsuarioTextBox.Text = "Insira seu usuário...";
                UsuarioTextBox.ForeColor = Color.Silver;
            }
        }

        private void SenhaTextBox_Enter(object sender, EventArgs e)
        {
            if(SenhaTextBox.Text == "Insira sua senha...")
            {
                SenhaTextBox.Text = "";
                SenhaTextBox.ForeColor = Color.Black;
            }
        }

        private void SenhaTextBox_Leave(object sender, EventArgs e)
        {
            if(SenhaTextBox.Text == "")
            {
                SenhaTextBox.Text = "Insira sua senha...";
                SenhaTextBox.ForeColor = Color.Silver; 
            }
        }

        private void ConfirmaSenhaTextBox_Enter(object sender, EventArgs e)
        {
            if(ConfirmaSenhaTextBox.Text == "Confirme sua senha...")
            {
                ConfirmaSenhaTextBox.Text = "";
                ConfirmaSenhaTextBox.ForeColor = Color.Black;
            }
        }

        private void ConfirmaSenhaTextBox_Leave(object sender, EventArgs e)
        {
            if(ConfirmaSenhaTextBox.Text == "")
            {
                ConfirmaSenhaTextBox.Text = "Confirme sua senha...";
                ConfirmaSenhaTextBox.ForeColor = Color.Silver;
            }
        }

        private void frmCadastroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Tem certeza que quer fechar?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void DataTextBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
