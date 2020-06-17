using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoDesktop
{
    class ConversaoIdioma
    {
        private static void ConversaoLinguagem(string culture)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture,true);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture, true);
        }

        private static void MudancaDeIdioma(Form frm, System.ComponentModel.ComponentResourceManager resx)
        {
            //frm.Text = resx.GetObject("$this.Text", System.Threading.Thread.CurrentThread.CurrentCulture).ToString();

            foreach(Control controle in frm.Controls)
            {
                resx.ApplyResources(controle, controle.Name, System.Threading.Thread.CurrentThread.CurrentCulture);
            }
        }

        public static void AlteraIdioma(Form frm, string culture)
        {
            ConversaoLinguagem(culture);
            System.ComponentModel.ComponentResourceManager resx = new System.ComponentModel.ComponentResourceManager(frm.GetType());
            MudancaDeIdioma(frm, resx);
        }
    }
}
