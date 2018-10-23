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
    public partial class segundaFase : Form
    {
        PanelGigante form;
        String texto = "Parado aí camponês, para entrar no castelo e enfrentar meu mestre precisa responder uma pergunta: ";
        pergunta p;             
        String resposta;

        int vidas = 3;

        int anim = 0;

        int acertou = 0;
        public segundaFase(PanelGigante form)
        {
            InitializeComponent();
            this.form = form;
            p = form.getPergunta().getPerguntaFase2();
            texto += p.Perg;
            resposta = p.Resp;
            form.setProgress(2);
        }

        private void segundaFase_Load(object sender, EventArgs e)
        {
            
            tmrAnima.Start();
        }

        private void txtResposta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.lblAnim.Text = texto;
                tmrAnima.Stop();

                if (acertou == 1)
                    form.mudarForm(new faseFinal(form), this);
                else
                if (acertou == -1)
                {
                    this.dialogar(p.Perg);
                    txtResposta.Text = "";
                    acertou = 0;
                    return;
                }


                if (this.txtResposta.Visible == true)
                    this.lblAnim.Text = "";

                if (this.txtResposta.Text == "")
                    return;
                else

                if (acertou == 0)
                {
                    if (txtResposta.Text.ToUpper() == this.resposta.ToUpper())
                    {
                        this.texto = "Pois bem, você acertou, pode entrar no castelo, o demoninho ali te guiará até o mestre, foi bom te conhecer, hihihihi.";
                        this.BackgroundImage = global::FormLogin.Properties.Resources.print_1;
                        acertou = 1;
                    }
                    else
                    {
                        this.texto = "HAHAHAHAHA, você errou";
                        acertou = -1;
                        vidas--;
                        if (vidas == 0)
                        {
                            form.mudarForm(new FormDerrota(form), this);
                        }

                        lblVidas.Text = "x " + vidas;
                    }
                    this.anim = 0;
                    this.tmrAnima.Start();
                }
                else
                acertou = 0;
            }
        }

        private void tmrAnima_Tick(object sender, EventArgs e)
        {
            if (anim >= texto.Length)
            {
                txtResposta.Visible = true;
                txtResposta.Focus();
                lbResposta.Visible = true;
                tmrAnima.Stop();
            }
            else
            {
                this.lblAnim.Text += texto.Substring(anim, 1);
                anim++;
            }
        }

        private void dialogar(String txt)
        {
            this.texto = txt;
            anim = 0;
            tmrAnima.Start();
        }

        private void segundaFase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtResposta.Visible == false)
            {
                txtResposta.Visible = true;
                lbResposta.Visible = true;
                lblAnim.Text = this.texto;
                this.tmrAnima.Stop();
            }
        }

        private void segundaFase_Shown(object sender, EventArgs e)
        {
            tmrAnima.Enabled = true;
            tmrAnima.Interval = 50;
        }
    }
}
