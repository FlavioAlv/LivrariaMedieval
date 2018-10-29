using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraMedievais
{
    public partial class CatalogoCliente : Form
    {
        public CatalogoCliente()
        {
            InitializeComponent();
        }



        private void Catalogo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'baseDadosDataSetGeral.Tabela_Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tabela_UsuarioTableAdapter.Fill(this.baseDadosDataSetGeral.Tabela_Usuario);
            // TODO: esta linha de código carrega dados na tabela 'baseDadosDataSet.Tabela_Locacao'. Você pode movê-la ou removê-la conforme necessário.
            // this.tabela_LocacaoTableAdapter.Fill(this.baseDadosDataSet.Tabela_Locacao);
            ListboxSenha.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ListboxSenha.Visible = true;
        }

        private void btnVoltarCl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
