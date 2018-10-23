using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class PanelGigante : Form
    {
        private perguntas p;
        usuario u;
        private SqlConnection BD;
        private int progresso = 0;
        public PanelGigante()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.mudarForm(new frmLogin(this), null);
            BD = new SqlConnection();
            BD.ConnectionString = "Data Source = Regulus; " +
                                   "Initial Catalog= BDPRII16186;" +
                                   "User id= BDPRII16186;" +
                                   "Password=ribeiro.rodrigu;";
            BD.Open();
        }

        public void setUsuario(usuario u)
        {
            this.u = u;
            if (u.Dif != "")
                gerarPerguntas(u.Dif);
        }

        public void setProgress(int i)
        {
            this.progresso = i;
        }

        public bool existeRegistro(string user, string senha)
        {
            try
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM USUARIO WHERE _user = @user and senha = @senha", BD);
                sql.Parameters.AddWithValue("@user", user);
                sql.Parameters.AddWithValue("@senha", senha);
                SqlDataReader rs = sql.ExecuteReader();
                if (rs.Read())
                {
                    String modo = (String)rs[2];
                    this.setUsuario(new usuario((String)rs[0], (String)rs[1], (String)rs[2], (int)rs[3]));
                    this.setProgress((int)rs[3]);
                    rs.Close();
                    return true;
                }
                rs.Close();
                return false;
            }
            catch (Exception e) { return false; }
        }
        public void exibeFase(Form frm)
        {
            switch (this.progresso)
            {
                case 0:
                    {
                        this.mudarForm(new frmDificuldade(this), frm);
                        break;
                    }
                case 1:
                    {
                        this.mudarForm(new primeiraFase(this), frm);
                        break;
                    }
                case 2:
                    {
                        this.mudarForm(new segundaFase(this), frm);
                        break;
                    }
                case 3:
                    {
                        this.mudarForm(new faseFinal(this), frm);
                        break;
                    }
            }
        }

        public bool alteraProgUsuario(int novo)
        {
            SqlCommand sql = new SqlCommand("update usuario set progresso = @novo where _user = @nome and senha = @senha", BD);
            sql.Parameters.AddWithValue("@nome", u.Nome);
            sql.Parameters.AddWithValue("@novo", novo);
            sql.Parameters.AddWithValue("@senha", u.Senha);
            int rs = sql.ExecuteNonQuery();
            if (rs > 0)
                return true;

            return false;
        }

        public bool alteraDifUsuario(String novo)
        {
            try
            {
                this.u.Dif = novo;
                gerarPerguntas(novo);
                SqlCommand sql = new SqlCommand("update usuario set dificuldade = @dif where _user = @nome and senha = @senha", BD);
                sql.Parameters.AddWithValue("@nome", u.Nome);
                sql.Parameters.AddWithValue("@dif", novo);
                sql.Parameters.AddWithValue("@senha", u.Senha);
                int rs = sql.ExecuteNonQuery();
                if (rs > 0)
                {
                    
                    return true;
                }
                
                return false;
            }
            catch (Exception e) {
                return false;
            }
        }

        public perguntas getPergunta()
        {
            return this.p;
        }
        public void gerarPerguntas(String modo)
        {
            this.p = new perguntas(modo);
        }

        public void mudarForm(Form form, Form frm)
        {
            if (frm != null)
            {
                pnlForms.Controls.Remove(frm);
                frm.Dispose();
            }

            this.Height = form.Height + 32;
            this.Width = form.Width + 10;

            form.TopLevel = false;
            form.AutoScroll = true;

            pnlForms.Controls.Add(form);

            form.Show();
            pnlForms.Controls[0].Focus();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void PanelGigante_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void PanelGigante_Load(object sender, EventArgs e)
        {

        }

        private void PanelGigante_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.alteraProgUsuario(progresso))
                MessageBox.Show("Até a próxima aventureiro, seu progresso foi salvo com sucesso.");
            else
                MessageBox.Show("Falha na tentativa de salvar o progresso.");

            BD.Close();
        }
    }
}
