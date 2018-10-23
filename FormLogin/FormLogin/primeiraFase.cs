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
    
    public partial class primeiraFase : Form
    {
        private PanelGigante form;
        private pergunta p;
        private int anim = 0;
        int vidas = 3;
        private string texto = "Alto lá viajante, para chegar no portão do castelo precisa passar por nós, e para passar por nós, precisa responder a pergunta:" +
                                " ";
        private string resposta ;
        private int acertou = 0;
        public primeiraFase(PanelGigante form)
        {
            InitializeComponent();
            this.form = form;
            this.p = form.getPergunta().getPerguntaFase1();
            texto += p.Perg;
            resposta = p.Resp;
            form.setProgress(1); 
        }

        private void primeiraFase_Load(object sender, EventArgs e)
        {
            lblAnim.Text = "";
            panel4.SendToBack();
            tmrAnima.Start();
           
        }

        private void dialogar(String txt)
        {
            this.texto = txt;
            anim = 0;
            tmrAnima.Start();
        }

        private void tmrAnima_Tick(object sender, EventArgs e)
        {
            if (anim >= texto.Length)
            {
                txtResposta.Visible = true;
                lbResposta.Visible = true;
                tmrAnima.Stop();
            }
            else
            {
                this.lblAnim.Text += texto.Substring(anim, 1);
                anim++;
            }
        }

        private void primeiraFase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtResposta.Visible == true && txtResposta.Text == "")
                {
                    this.dialogar("Escreva algo viajante");
                }

                txtResposta.Visible = true;
                txtResposta.Focus();
                lbResposta.Visible = true;
                lblAnim.Text = this.texto;
                this.tmrAnima.Stop();
            }
            

        }

        private void primeiraFase_Shown(object sender, EventArgs e)
        {
            tmrAnima.Enabled = true;
            tmrAnima.Interval = 50;
        }
        private void txtResposta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.lblAnim.Text = texto;
                tmrAnima.Stop();

                if (acertou == 1)
                    form.mudarForm(new segundaFase(form), this);
                else
                if (acertou == -1)
                    this.dialogar(p.Perg);                

                if (this.txtResposta.Visible == true)
                    this.lblAnim.Text = "";

                if (this.txtResposta.Text == "")
                    return;
                else

                if (acertou == 0)
                {
                    if (txtResposta.Text.ToUpper() == this.resposta.ToUpper())
                    {
                        this.dialogar("DROGA!!!, você acertou, tá bom... Pode passar. ");
                        acertou = 1;
                    }
                    else
                    {
                        acertou = -1;
                        this.dialogar("HAHAHAHAHA, você errou");
                        vidas--;
                        if (vidas == 0)
                        {
                            form.mudarForm(new FormDerrota(form), this);
                        }

                        lblVidas.Text = "x " + vidas;

                    }

                }
                else
                    acertou = 0;
            }
        }
        private void lblAnim_Click(object sender, EventArgs e)
        {

        }

        private void primeiraFase_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void primeiraFase_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void primeiraFase_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void primeiraFase_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
