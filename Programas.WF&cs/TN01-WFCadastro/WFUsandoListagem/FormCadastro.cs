using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUsandoListagem
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }
        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuarioNovo.Text))
            {
                Erro("Campo Usuário não pode estar Vazio!");
                return;
            }
            //Verifica 
            else if (string.IsNullOrEmpty(txtSenhaNova.Text))
            {
                Erro("Campo Senha não pode estar Vazia!");
                return;
            }
            ////Verifica 
            else if (txtSenhaNova.Text != txtConfirmarSenha.Text)
            {
                Erro("As senhas não podem ser diferentes");
                return;
            }
            ////Verifica 
            else if (txtSenhaNova.Text == txtConfirmarSenha.Text)
            {
                Sucesso("Usuário cadastrado com sucesso!");
            }

            Usuario us1 = new Usuario();
            us1.Codigo = Usuario.ListaUsuarios.Count + 1;
            us1.Login = txtUsuarioNovo.Text;
            us1.Senha = txtSenhaNova.Text;
            us1.DataCadastro = DateTime.Now;

            Usuario.ListaUsuarios.Add(us1);
        }
    }
}
