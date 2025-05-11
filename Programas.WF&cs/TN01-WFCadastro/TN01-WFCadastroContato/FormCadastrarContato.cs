using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01_WFCadastroContato_
{
    public partial class FormCadastrarContato : Form
    {
        public FormCadastrarContato()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            string telefone = mkdTelefone.Text;
            string email = txtEmail.ToString();
            string tipoTelefone = "";


            if (rdbPessoal.Checked)
            {
                tipoTelefone = "Pessoal";
            }
            else if (rdbComercial.Checked)
            {
                tipoTelefone = "Comercial";
            }
            else if (rdbRecado.Checked)
            {
                tipoTelefone = "Recado";
            }
            else
            {
                MessageBox.Show("Nenhum tipo de telefone foi selecionado!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNome.Text == "" || txtSobrenome.Text == "" || mkdTelefone.Text == "" || txtEmail.ToString() == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
