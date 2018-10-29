using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraMedievais
{
    public class Logado
    {
        public bool Logar(TextBox user, TextBox senha)
        {
            CodigosGerais c = new CodigosGerais();

            if (c.TestLogin(user, " Usuário "))
                return false;
            if (c.TestLogin(senha, " Senha "))
                return false;

            if((user.Text == "Junior") && (senha.Text == "123"))
            {
                c.MostrarMSG("3", user.Text + " Seja Bem vindo ! ");
                return true;
            }
            else
            {
                c.MostrarMSG("1", " Usuario nao encontrado.. ");
                return false;
            }
        }
    }
}
