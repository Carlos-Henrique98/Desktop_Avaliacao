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
    public partial class frmListarUsuario : Form
    {
        UsuarioRepository repository = new UsuarioRepository();
        private static Usuario x = new Usuario();
        Usuario usuario = new Usuario();

        public frmListarUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void NovoBtn_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario cadastroUsuario = new frmCadastroUsuario();
            cadastroUsuario.Show();
        }

        private void VoltarBtn_Click(object sender, EventArgs e)
        {
            frmPrincipalU principalU = new frmPrincipalU();
            principalU.Show();
        }

        private void dgvListarUsuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                DialogResult dr = MessageBox.Show("Deseja excluir este usuário?", "Atenção",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    DataGridViewRow linha = dgvListarUsuario.Rows[e.RowIndex];

                    int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());

                    UsuarioRepository repository = new UsuarioRepository();
                    repository.deletar(codigo);

                    carregaLista();
                }
            }
        }

        private void DeletaBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Excluir usuário?", "Atenção",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if(dr == DialogResult.Yes)
            {
                repository.deletar(x.Id);
            }
        }

        private void dgvListarUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dgvListarUsuario.Rows[e.RowIndex];

            int id = Convert.ToInt32(linha.Cells[0].Value.ToString());
            string nome = linha.Cells[1].Value.ToString();
            string sobrenome = linha.Cells[2].Value.ToString();
            string endereco = linha.Cells[3].Value.ToString();
            string nascimento = linha.Cells[4].Value.ToString();
            string numero = linha.Cells[5].Value.ToString();
            string usuario = linha.Cells[6].Value.ToString();
            string senha = linha.Cells[7].Value.ToString();

            usuario.Id = id;
            usuario.Nome = nome;
            usuario.Sobrenome = sobrenome;
            usuario.Endereco = endereco;
            usuario.dataNascimento = Convert.ToDateTime(nascimento);
            usuario.Numero = numero;
            usuario.Usuario = usuario;
            usuario.Senha = senha;





            //int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());
            //x = repository.BuscarPorId(codigo);
            //tbxNome.Text = x.nome;
            //tbxSobrenome.Text = x.sobrenome;
            //tbxEndereco.Text = x.endereco;
            //dtpNascimento.Text = Convert.ToString(x.dataNascimento);
            //tbxNumero.Text = x.numero;
            //tbxUsuario.Text = x.usuario;
            //tbxSenha.Text = x.senha;

            //carregaLista();
        }

        private void carregaLista()
        {
            UsuarioRepository repository = new UsuarioRepository();
            dgvListarUsuario.DataSource = null;
            dgvListarUsuario.DataSource = repository.buscarTodos();
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            // Usuario usuarioEditado = new Usuario
            //{
            //    nome = tbxNome.Text,
            //    sobrenome = tbxSobrenome.Text,
            //     endereco = tbxEndereco.Text,
            //     dataNascimento = Convert.ToDateTime(dtpNascimento.Text),
            //     numero = tbxNumero.Text,
            //     usuario = tbxUsuario.Text,
            //     senha = tbxSenha.Text,
            //     confirmaSenha = tbxConfirSenha.Text,
            // };

            // repository.editar(usuarioEditado);
            // MessageBox.Show("Perfil editado", "Editado");
            // carregaLista();

            new frmCadastroUsuario(usuario).ShowDialog();
            carregaLista();


        }

        private void dgvListarUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
