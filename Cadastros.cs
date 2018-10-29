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
    public partial class Cadastros : Form
    {
        public Cadastros()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CodigosGerais c = new CodigosGerais();
            SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=false;Initial Catalog=BaseDados;Data Source=.\\SQLEXPRESS01");

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Login_user(Usuario, Senha) VALUES(@Usuario, @Senha)", conn);

            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = txtUser.Text;
            cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtSenha.Text;

            if (txtUser.Text != "" & txtSenha.Text != "")
            {
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    c.MostrarMSG("3", "Cadastro Concluído !");
                    txtSenha.Text = "";
                    txtUser.Text = "";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
