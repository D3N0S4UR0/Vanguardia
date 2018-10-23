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
    public partial class faseFinal : Form
    {
        PanelGigante form;
        String texto = "AAAH, então você chegou, sabia que deveria ter escolhido melhor meus lacaios, aqueles incompetentes não conseguem nem segurar " +
                       "um simples camponês idiota, bom... Não faz mal, daqui você só passa se acertar as minhas 5 perguntas, e isso nunca vai acontecer HAHAHAHAHA.";
        pergunta[] p;
        String perguntaAtual;
        String respostaAtual;

        int acertou = 0;

        int atual = -2;

        int vidas = 3;

        int anim = 0;

        public faseFinal(PanelGigante form)
        {
            InitializeComponent();
            this.form = form;
            
            form.setProgress(3);
        }

        private void faseFinal_Load(object sender, EventArgs e)
        {
            
            tmrAnima.Start();
            this.p = form.getPergunta().getPerguntaFaseFinal();
        }

        private void txtResposta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.lblAnim.Text = texto;
                tmrAnima.Stop();
                
                if (this.txtResposta.Visible == true)
                {
                    

                    if (this.acertou == 1)
                    {
                        if (atual == 4)
                            this.form.mudarForm(new formVitoria(form), this);
                        else
                        {
                            atual++;
                            this.perguntaAtual = p[atual].Perg;
                            this.respostaAtual = p[atual].Resp;
                            this.dialogar(perguntaAtual);
                            txtResposta.Text = "";
                            txtResposta.Focus();
                            acertou = 0;
                        }                       

                    }

                    else if(acertou == -1)
                    {
                        this.dialogar(perguntaAtual);
                        acertou = 0;
                        return;
                    }

                    if (this.txtResposta.Text == "")
                    {
                        return;
                    }

                    this.lblAnim.Text = texto;
                   if (txtResposta.Text.ToUpper().Equals(respostaAtual.ToUpper()))
                    {
                   
                        acertou = 1;

                        if (atual !=4)
                    {
                           if (atual == 3)
                                panel1.BackgroundImage = global::FormLogin.Properties.Resources.magoMeioTiltado1;

                           if (atual >= 3)
                                this.dialogar("NÃO É POSSÍVEL, UM PLEBEU NÃO PODE ME DERROTAR, PRÓXIMA PERGUNTA!!!!!");
                           else
                            this.dialogar("ACERTOU? Hmmf, deu sorte, quero ver acertar a próxima ");

                            

                    }
                    else
                    {
                        panel1.BackgroundImage = global::FormLogin.Properties.Resources.magoTiltado;
                            this.dialogar("TÁ BOM TÁ BOM, você ganhou... agora pegue sua amada e SUMA DO MEU CASTELO!!!");
                    }
                }
                else
                {
                    vidas--;
                    this.dialogar("HAHAHAHAHA, você errou, agora só tem mais " + vidas + " vidas");
                        acertou = -1;
                    if (vidas == 0)
                    {
                        form.mudarForm(new FormDerrota(form), this);
                    }

                    lblVidas.Text = "x " + vidas;
                }
                }

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
            lblAnim.Text = "";
            anim = 0;
            tmrAnima.Start();
        }

        private void faseFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblAnim.Text = this.texto;
                this.tmrAnima.Stop();

                atual++;
                if (atual == 0)
                {
                    txtResposta.Visible = true;
                    lbResposta.Visible = true;
                    
                    this.perguntaAtual = p[atual].Perg;
                    this.respostaAtual = p[atual].Resp;
                    this.dialogar(perguntaAtual);
                    
                }
            }
        }

        private void faseFinal_Shown(object sender, EventArgs e)
        {
            tmrAnima.Enabled = true;
            tmrAnima.Interval = 50;
        }
    }
}
