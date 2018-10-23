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
    public partial class frmLogin : Form
    {
        PanelGigante form;
        SqlConnection BD;
        public frmLogin(PanelGigante frm)
        {
            form = frm;
            InitializeComponent();
            BD = new SqlConnection();
            BD.ConnectionString = "Data Source = Regulus; " +
                                   "Initial Catalog= BDPRII16186;" +
                                   "User id= BDPRII16186;" +
                                   "Password=ribeiro.rodrigu;";
        }

        private bool inicializarRegistro(string user, string senha)
        {
            try
            {
                BD.Open();
                SqlCommand sql = new SqlCommand("SELECT * FROM USUARIO WHERE _user = @user and senha = @senha", BD);
                sql.Parameters.AddWithValue("@user", user);
                sql.Parameters.AddWithValue("@senha", senha);
                SqlDataReader rs = sql.ExecuteReader();
                if (rs.Read())
                {
                    String modo = (String)rs[2];
                    form.setUsuario(new usuario((String)rs[0], (String)rs[1], (String)rs[2], (int)rs[3]));
                    form.setProgress((int)rs[3]);
                    rs.Close();
                    BD.Close();
                    return true;
                }
                rs.Close();
                BD.Close();
                return false;
            }
            catch (Exception e) { return false; }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (form.existeRegistro(txtUsuario.Text, txtSenha.Text))
            {
                form.exibeFase(this);
            }
            else
                MessageBox.Show("Não foi encontrado usuário que corresponda a esses dados");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_KeyUp(object sender, KeyEventArgs e)
        {
         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form.mudarForm(new FormCadastro(form), this);
        }
    }
}
