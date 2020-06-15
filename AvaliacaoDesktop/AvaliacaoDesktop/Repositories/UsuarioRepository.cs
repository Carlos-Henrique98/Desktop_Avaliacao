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
                    nome = "Fernando",
                    sobrenome = "Henrique",
                    usuario = "FerHenri",
                    senha = "123456",
                    confirmaSenha = "123456"
                }
                );
                contador++;
                usuarios.Add(new Usuario
                {
                    codigo = 2,
                    nome = "Magali",
                    sobrenome = "Dias",
                    usuario = "Mag",
                    senha = "Mag2020",
                    confirmaSenha = "Mag2020"
                }
              );
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
    }
}
