using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class formVitoria : Form
    {
        PanelGigante form;
        public formVitoria(PanelGigante form)
        {
            InitializeComponent();
            this.form = form;
            form.setProgress(0);
        }

        private void formVitoria_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                form.mudarForm(new frmDificuldade(form), this);
            }
        }

        private void formVitoria_Load(object sender, EventArgs e)
        {

        }
    }
}
