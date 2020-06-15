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
    public partial class frmListarUsuario : Form
    {
        public frmListarUsuario()
        {
            InitializeComponent();
        }

        private void tbxSenha_TextChanged(object sender, EventArgs e)
        {
            string senhaValida = "[]";
            
        }

        private void NovoBtn_Click(object sender, EventArgs e)
        {
            tbxNome.Clear();
            tbxSobrenome.Clear();
            tbxEndereco.Clear();
            tbxNumero.Clear();
            tbxUsuario.Clear();
            tbxSenha.Clear();
            tbxConfirSenha.Clear();
        }
    }
}
