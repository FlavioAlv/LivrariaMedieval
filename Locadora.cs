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

namespace LocadoraMedievais
{
    public partial class Locadora : Form
    {
        public Locadora()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CodigosGerais c = new CodigosGerais();

            SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BaseDados;Data Source=.\\SQLEXPRESS01");

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select Usuario,Senha FROM dbo.Login_user WHERE Usuario =@Usuario And Senha=@Senha";
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = txtUser.Text;
            cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtSenha.Text;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                c.MostrarMSG("3", " Seja Bem Vindo " + txtUser.Text);
                this.Visible = false;
                LocadoraSistem locad = new LocadoraSistem();
                locad.ShowDialog();
            }
            else 
            {
                c.MostrarMSG("1", "Usuário ou Senha Incorretos.");
                
            }
            conn.Close();
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastros cad = new Cadastros();
            cad.ShowDialog();
           
        }

        private void Locadora_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }
    }
}
