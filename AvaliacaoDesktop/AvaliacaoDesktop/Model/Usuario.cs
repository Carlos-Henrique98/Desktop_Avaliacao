using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoDesktop
{
    class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Endereco { get; set; }

        public string Numero { get; set; }

        public DateTime dataNascimento { get; set; }

        public string UserName { get; set; }

        public string Senha { get; set; }

        public string ConfirmaSenha { get; set; }
    }
}
