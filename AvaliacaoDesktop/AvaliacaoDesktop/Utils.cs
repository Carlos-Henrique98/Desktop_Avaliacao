using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoDesktop
{
    class Utils
    {
        public static bool temCamposVazio(Form form)
        {
            foreach(Control c in form.Controls)
            {
               TextBox tbx = c as TextBox;
        
                if(tbx != null && tbx.Text.Trim().Length == 0)
              {
                    return true;
                 }
            }
            return false;
        }

        public bool campoVazio(Control controle,string campo)
        {
            if(controle.Text == "")
            {
                MessageBox.Show("O campo "+campo+" é obrigatório!");
                controle.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
