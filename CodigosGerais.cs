using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LocadoraMedievais
{
    public class CodigosGerais
    {
        //Codigo referente a Mensagem mostrada ao efetuar Login... 1 User, 2 Error, 3 Validado.
        public void MostrarMSG(string tipo, string texto)
        {
            FrmAviso frm = new FrmAviso();

            frm.lblAviso.Text = texto;

            //Erro Usuario
            if(tipo == "1")
            {
                frm.pctUser.Visible = true;
                frm.pctValidated.Visible = false;
                frm.btnProsseguir.Visible = false;
                //frm.BackColor = Color.OrangeRed;
                frm.ShowDialog();
            }
            //Verificado
            if(tipo == "3")
            {
                frm.pctValidated.Visible = true;
                frm.pctUser.Visible = false;
                //frm.BackColor = Color.LimeGreen;
                frm.button1.Visible = false;
                frm.ShowDialog();
            }
        }

        public bool TestLogin (Control controlador, string campo)
        {
            if(controlador.Text == "")
            {
                MostrarMSG("1", "O campo " + campo + " é obrigatório..");
                controlador.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
