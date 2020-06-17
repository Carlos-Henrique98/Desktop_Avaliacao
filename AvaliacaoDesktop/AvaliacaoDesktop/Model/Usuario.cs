using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoDesktop
{
    class Usuario
    {
        public int codigo { get; set; }

        public string nome { get; set; }

        public string sobrenome { get; set; }

        public string endereco { get; set; }

        public string numero { get; set; }

        public DateTime dataNascimento { get; set; }

        public string usuario { get; set; }

        public string senha { get; set; }

        public string confirmaSenha { get; set; }
    }
}
