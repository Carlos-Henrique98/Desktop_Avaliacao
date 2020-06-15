using AvaliacaoDesktop.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            //if(usuario != null)
            {

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
                UsuarioRepository repository = new UsuarioRepository();
                if(this.usuario == null)
                {
                    Usuario usuario = new Usuario
                    {
                        nome = NomeTextBox.Text,
                        sobrenome = SobrenomeTextBox.Text,
                        endereco = EnderecoTextBox.Text,
                        usuario = UsuarioTextBox.Text,
                        senha = SenhaTextBox.Text,
                        confirmaSenha = ConfirmaSenhaTextBox.Text
                        
                    };
                    repository.adicionar(usuario);

                    MessageBox.Show("Dados Salvos.","Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                } 
            }
            else
            {
                if(NomeTextBox.Text.Trim().Length == 0 || SobrenomeTextBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Campo dos nomes não inserido");
                }
                else if(EnderecoTextBox.Text.Trim().Length == 0 || NumeroTextBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Campo do endereco não inserido");
                }
                else if(UsuarioTextBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Campo de usuario não inserido");
                }
                else if(SenhaTextBox.Text.Trim().Length == 0 || ConfirmaSenhaTextBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Campo de senha não inserido");
                }
            }

            //ERRADO
            if(SenhaTextBox.Text.Trim() == ConfirmaSenhaTextBox.Text.Trim())
            {
                MessageBox.Show("Os campos da senhas não iguais");
            }
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            
        }
    }
}
