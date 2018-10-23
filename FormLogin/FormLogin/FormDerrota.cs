using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class FormDerrota : Form
    {
        PanelGigante form;
        public FormDerrota(PanelGigante form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void FormDerrota_Load(object sender, EventArgs e)
        {
           
        }

        private void FormDerrota_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormDerrota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                form.exibeFase(this);

            if (e.KeyCode == Keys.Escape)
                form.Dispose();
        }
    }
}
