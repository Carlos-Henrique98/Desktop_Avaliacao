using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoDesktop.Repositories
{
    class UsuarioRepository
    {
        private static List<Usuario> usuarios;

        private static int contador = 1;

        public UsuarioRepository()
        {
            if(usuarios == null)
            {
                usuarios = new List<Usuario>();

                usuarios.Add(new Usuario
                {
                    codigo = 1,
                    nome = "Gabriel",
                    sobrenome = "Santos",
                    dataNascimento = Convert.ToDateTime("09/02/1968"),
                    endereco = "Gasometro",
                    numero = "543",
                    usuario = "admin",
                    senha = "12345",
                });
                contador++;
                usuarios.Add(new Usuario
                {
                   codigo = 2,
                   nome = "Guilherme",
                   sobrenome = "Borges",
                   dataNascimento = Convert.ToDateTime("16/08/2000"),
                   endereco = "Av. Paulista",
                   numero = "123",
                   usuario = "comum",
                   senha = "54321",
                });
                contador++;
            }
        }

        public List<Usuario> buscarTodos()
        {
            return usuarios;
        }

        public void adicionar(Usuario usuario)
        {
            usuario.codigo = contador;

            usuarios.Add(usuario);
            contador++;
        }

        public void editar (Usuario usuario)
        {
            Usuario u = usuarios.Find(x => x.codigo == usuario.codigo);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }

        public void deletar(int codigo)
        {
            Usuario usuario = usuarios.Find(x => x.codigo == codigo);
            usuarios.Remove(usuario);
        }

        public Usuario BuscarPorId(int codigo)
        {
            return usuarios.FirstOrDefault(x => x.codigo == codigo);
        }
    }
}
