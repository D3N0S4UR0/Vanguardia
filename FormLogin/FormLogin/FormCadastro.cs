using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormLogin
{
    public partial class FormCadastro : Form
    {
        SqlConnection BD;
        PanelGigante form;
        public FormCadastro(PanelGigante frm)
        {
            this.form = frm;
            InitializeComponent();
            BD = new SqlConnection();
            BD.ConnectionString = "Data Source = Regulus; " +
                                   "Initial Catalog= BDPRII16186;" +
                                   "User id= BDPRII16186;" +
                                   "Password=ribeiro.rodrigu;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            if (usuario.Equals("") || senha.Equals(""))
                MessageBox.Show("Dados inválidos");
            else
            {
                if (form.existeRegistro(usuario, senha))
                    MessageBox.Show("já existe esse nome de usuário ou senha, favor inserir dados diferentes");

                else
                {
                    try
                    {
                        BD.Open();
                        SqlCommand sql = new SqlCommand("INSERT INTO USUARIO VALUES(@user, @senha, @diff, @prog)", BD);
                        sql.Parameters.AddWithValue("@user", usuario);
                        sql.Parameters.AddWithValue("@senha", senha);
                        sql.Parameters.AddWithValue("@diff", "");
                        sql.Parameters.AddWithValue("@prog", "0");
                        int linhas = sql.ExecuteNonQuery();
                        if (linhas == 0)
                            MessageBox.Show("Ocorreu um erro na inserção, favor tente novamente");
                        else
                            MessageBox.Show("Usuario Cadastrado com sucesso");

                        BD.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.form.mudarForm(new frmLogin(form),this);
        }
    }
}
