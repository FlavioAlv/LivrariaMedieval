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
    public partial class CatalogoLocacao : Form
    {
        public CatalogoLocacao()
        {
            InitializeComponent();
        }

        private void CatalogoLocacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'baseDadosDataSetGeral.Tabela_Locacao'. Você pode movê-la ou removê-la conforme necessário.
            this.tabela_LocacaoTableAdapter.Fill(this.baseDadosDataSetGeral.Tabela_Locacao);

        }

        private void btnVoltarCat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
