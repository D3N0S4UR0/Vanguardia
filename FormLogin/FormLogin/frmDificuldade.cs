using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace FormLogin
{
    public partial class frmDificuldade : Form
    {
        PanelGigante form;
        public frmDificuldade(PanelGigante form)
        {
            InitializeComponent();
            Link l = new Link();
            this.form = form;
        }

        private void linkFoiClicado(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel l = (LinkLabel)sender;
            String modo = l.Name;
            if (form.alteraDifUsuario(modo))
                form.mudarForm(new frmTeste(form), this);
            else
                MessageBox.Show("mamoou");
        }
    }
}
