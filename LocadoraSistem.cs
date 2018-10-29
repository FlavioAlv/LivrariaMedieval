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
    public partial class LocadoraSistem : Form
    {
        public LocadoraSistem()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            CodigosGerais c = new CodigosGerais();

            SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=true;Initial Catalog=BaseDados;Data Source=.\\SQLEXPRESS01");

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Tabela_Usuario(Nome, Telefone, CPF, Usuario, Senha) VALUES (@Nome, @Telefone, @CPF, @Usuario, @Senha)", conn);

            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNomeUser.Text;
            cmd.Parameters.Add("@Telefone", SqlDbType.BigInt).Value = txtTelUser.Text;
            cmd.Parameters.Add("@CPF", SqlDbType.BigInt).Value = txtCPF.Text;
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = txtUsuario.Text;
            cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtSenha.Text;

            if(txtNomeUser.Text  != "" & txtTelUser.Text != "" & txtCPF.Text != "" & txtUsuario.Text != "" & txtSenha.Text != "" )
            {
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    c.MostrarMSG("3", "Cadastrado !");
                    txtNomeUser.Text = "";
                    txtTelUser.Text = "";
                    txtCPF.Text = "";
                    txtUsuario.Text = "";
                    txtSenha.Text = "";

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    conn.Close();
                    gBoxCadastro.Enabled = false;
                }
            }
            else
            {
                c.MostrarMSG("1", "Preencha todos os Campos..");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gBoxCadastro.Enabled = true;
        }

        private void btnConfirmaLivro_Click(object sender, EventArgs e)
        {
            CodigosGerais c = new CodigosGerais();

            SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=true;Initial Catalog=BaseDados;Data Source=.\\SQLEXPRESS01");

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Cad_Livro(Titulo, Autor, Editora, Classe) VALUES(@Titulo, @Autor, @Editora, @Classe)", conn);

            cmd.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = txtTitulo.Text;
            cmd.Parameters.Add("@Autor", SqlDbType.VarChar).Value = txtAutor.Text;
            cmd.Parameters.Add("@Editora", SqlDbType.VarChar).Value = txtEditora.Text;
            cmd.Parameters.Add("@Classe", SqlDbType.VarChar).Value = cbxClass.Text;

            if (txtTitulo.Text != "" & txtAutor.Text != "" & txtEditora.Text != "" & cbxClass.Text != "")
            {
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    c.MostrarMSG("3", "Cadastrado !");
                    txtTitulo.Text = "";
                    txtAutor.Text = "";
                    txtEditora.Text = "";
                    cbxClass.Text = "";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);

                }
                finally
                {
                    conn.Close();
                    gBoxLivros.Enabled = false;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gBoxLivros.Enabled = true;
        }

        private void btnConfirmaLoc_Click(object sender, EventArgs e)
        {
            
            CodigosGerais c = new CodigosGerais();

            SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=true;Initial Catalog=BaseDados;Data source=.\\SQLEXPRESS01");

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Tabela_Locacao(Nome_Usuario, Nome_Livro, Autor_Livro, Quantidade, Classificacao) VALUES (@Nome_Usuario, @Nome_Livro, @Autor_Livro, @Quantidade, @Classificacao)", conn);

            cmd.Parameters.Add("@Nome_Usuario", SqlDbType.VarChar).Value = txtUserLoc.Text;
            cmd.Parameters.Add("@Nome_Livro", SqlDbType.VarChar).Value = txtTituloLoc.Text;
            cmd.Parameters.Add("@Autor_Livro", SqlDbType.VarChar).Value = txtAutorLoc.Text;
            cmd.Parameters.Add("@Quantidade", SqlDbType.Int).Value = txtQtde.Text;
            cmd.Parameters.Add("@Classificacao", SqlDbType.VarChar).Value = cbxClass1.Text;

            if (txtUserLoc.Text != "" & txtTituloLoc.Text != "" & txtAutorLoc.Text != "" & txtQtde.Text != "" & cbxClass1.Text != "")
            {
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    c.MostrarMSG("3", "Cadastrado !");
                    txtUserLoc.Text = "";
                    txtTituloLoc.Text = "";
                    txtAutorLoc.Text = "";
                    txtQtde.Text = "";
                    cbxClass1.Text = "";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    conn.Close();
                    gBoxLivros.Enabled = false;
                }
            }
            else
            {
                c.MostrarMSG("1", "Prrencha todos os Campos..");
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            FlowPainelCliente.Visible = true;
            btnFechaAba.Visible = true;
            SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=true;Initial Catalog=BaseDados;Data source=.\\SQLEXPRESS01");

            SqlCommand cmd = new SqlCommand("SELECT Nome, Telefone, CPF, Usuario, Senha FROM dbo.Tabela_Usuario WHERE Nome = @Nome", conn);

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtBuscarUser.Text;
            cmd.CommandType = CommandType.Text;

            if (txtBuscarUser.Text != "")
            {
                try
                { 
                    conn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();

                    lblNomeUser.Text = dataReader.GetString(1);
                    lblTelefone.Text = dataReader.GetString(2);
                    lblCPF.Text = dataReader.GetString(3);
                    lblUser.Text = dataReader.GetString(0);
                    lblSenhaUser.Text = dataReader.GetString(4);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    conn.Close();
                    //FlowPainelCliente.Visible = false;
                }
            }
        }

        private void btnLocacao_Click(object sender, EventArgs e)
        {
            gBoxLocacao.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblSenhaUser.Visible = true;
        }

        private void btnFechaAba_Click(object sender, EventArgs e)
        {
            btnFechaAba.Visible = false;
            FlowPainelCliente.Visible = false;
            txtBuscarUser.Text = "";
        }

        private void btnPesquisaLivro_Click(object sender, EventArgs e)
        {
            FlowPainelLivro.Visible = true;
            btnFechaAba2.Visible = true;
            SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=true;Initial Catalog=BaseDados;Data Source=.\\SQLEXPRESS01");

            SqlCommand cmd = new SqlCommand("SELECT Titulo, Autor, Editora, Classe FROM dbo.Cad_Livro WHERE Titulo = @Titulo", conn);

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = txtBuscarLivro.Text;
            cmd.CommandType = CommandType.Text;

            if(txtBuscarLivro.Text != "")
            {
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();

                    lblTitulo.Text = dataReader.GetString(0);
                    lblAutor.Text = dataReader.GetString(1);
                    lblEditora.Text = dataReader.GetString(2);
                    lblClass.Text = dataReader.GetString(3);

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

        private void btnFechaAba2_Click(object sender, EventArgs e)
        {
            btnFechaAba2.Visible = false;
            FlowPainelLivro.Visible = false;
            txtBuscarLivro.Text = "";
        }

        private void btnVerCliente_Click(object sender, EventArgs e)
        {
            CatalogoCliente cat = new CatalogoCliente();
            cat.ShowDialog();
        }

        private void btnVerLivro_Click(object sender, EventArgs e)
        {
            CatalogoLivro cat = new CatalogoLivro();
            cat.ShowDialog();
        }

        private void btnCatalogLoc_Click(object sender, EventArgs e)
        {
            CatalogoLocacao cat = new CatalogoLocacao();
            cat.ShowDialog();
        }

        private void btnFechaTd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
