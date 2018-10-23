using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{

    public partial class frmTeste : Form
    {
        String texto = "  No reino longínquo de Vanguardia, morava um pobre campônes chamado Londor, e juntamente com sua amada Belona, eram felizes "
                        + "apesar das dificuldades de ser um camponês em um reino tão injusto, passar fome não era nada se tivesse sua amada ao seu lado.\n"
                        + "  Porém em um nublado dia de chuva, os céus ficaram negros e uma atmosfera gigantesca de terror pesou sobre os ombros dos camponeses"
                        + "e quando menos perceberam criaturas monstruosas com asas raptavam camponeses por toda a cidade, e um desses era Belona, sendo levada "
                        + "pela criatura até onde não se pode enxergar.";
        int anim = 0;
        PanelGigante form;
        public frmTeste(PanelGigante frm)
        {
            InitializeComponent();
            
            this.form = frm;
        }

        private void tmTexto_Tick(object sender, EventArgs e)
        {
            if (anim >= texto.Length)
                tmTexto.Stop();
            else
            {
                this.lblAnim.Text += texto.Substring(anim, 1);
                anim++;
                Application.DoEvents();
            }
        }

        private void frmTeste_KeyUp(object sender, KeyEventArgs e)
        {
            
            
        }

        private void frmTeste_MouseClick(object sender, MouseEventArgs e)
        {
 
        }

        private void frmTeste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lblAnim.Text.Equals(texto))
                    form.mudarForm(new primeiraFase(form), this);

                tmTexto.Stop();
                lblAnim.Text = texto;
            }
        }

        private void frmTeste_Load(object sender, EventArgs e)
        {

        }

        private void frmTeste_Shown(object sender, EventArgs e)
        {
            this.tmTexto.Enabled = true;
            this.tmTexto.Interval = 40;
        }
    }
}
