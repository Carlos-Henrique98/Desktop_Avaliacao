using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoDesktop
{
    public partial class frmLogin : Form
    {
        Timer t = new Timer();
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = this.Size;
            this.Text = "Login | AvaliacaoDesktop";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {

        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Trim().Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Digite o usuário.", "Erro");
            }
            else if (txtSenha.Text.Trim().Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Digite a senha", "Erro");
            }
            else
            {
                MessageBox.Show("Bem vindo", "Entrada");
                if(txtUsuario.Text.Trim() == "admin" && txtSenha.Text.Trim() == "1234")
                {
                    frmPrincipalA telaPrincipalA = new frmPrincipalA();
                    telaPrincipalA.ShowDialog();
                }
                else
                {
                    frmPrincipalU telaPrincipalU = new frmPrincipalU();
                    telaPrincipalU.ShowDialog();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            //txtUsuario.Clear();
            //txtSenha.Clear();

            frmCadastroUsuario novoUsuario = new frmCadastroUsuario();
            novoUsuario.Show();
        }

        private void btImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog picture = new OpenFileDialog();
            picture.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";

            if(picture.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.BackgroundImage = Image.FromFile(picture.FileName);
            }
        }

        private void btLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog logo = new OpenFileDialog();
            logo.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";

            if(logo.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox1.BackgroundImage = Image.FromFile(logo.FileName);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            t.Interval = 5000;

            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if(hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if(mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if(ss < 10)
            {
                time += "0" + ss;
            }
            else 
            {
                time += ss;
            }
            lblTimer.Text = time;
        }

    }
}
