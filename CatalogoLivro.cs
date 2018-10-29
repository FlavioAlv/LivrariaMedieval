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
    public partial class CatalogoLivro : Form
    {
        public CatalogoLivro()
        {
            InitializeComponent();
        }

        private void CatalogoLivro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'baseDadosDataSetGeral.Cad_Livro'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_LivroTableAdapter.Fill(this.baseDadosDataSetGeral.Cad_Livro);

        }

        private void btnVoltarLiv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
