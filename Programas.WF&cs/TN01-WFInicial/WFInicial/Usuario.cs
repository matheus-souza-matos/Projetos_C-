using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFInicial
{
    public class Usuario
    {
        public string? Nome { get; set; }

        public string? Senha { get; set; }

        /*
          Faça um formulário que leia um nome de usuário e a senha.
          A senha não pode ser igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações/
        */

        public bool EfetuarLogin()
        {
            if(Nome == Senha)
            {
                MessageBox.Show("A senha e usuário não podem ser iguais!", "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;

            }
            else
            {
                return true;
            }
        }
    }
}
