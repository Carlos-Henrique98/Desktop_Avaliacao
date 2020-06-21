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
            }
        }

        public List<Usuario> buscarTodos()
        {
            return usuarios;
        }

        public void adicionar(Usuario usuario)
        {
            usuario.Id = contador;

            usuarios.Add(usuario);
            contador++;
        }

        public void editar (Usuario usuario)
        {
            Usuario u = usuarios.Find(x => x.Id == usuario.Id);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }

        public void deletar(int Id)
        {
            Usuario usuario = usuarios.Find(x => x.Id == Id);
            usuarios.Remove(usuario);
        }

        public Usuario BuscarPorId(int codigo)
        {
            return usuarios.FirstOrDefault(x => x.Id == codigo);
        }

        public Usuario BuscarUsuario(string user, string senha)
        {
            if(user != null && senha != null)
            {
                Usuario usuario = usuarios.Find(x => x.UserName == user && x.Senha == senha);
                return usuario;
            }
            else
            {
                return null;
            }
        }
    }
}
