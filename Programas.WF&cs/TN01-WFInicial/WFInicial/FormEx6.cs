using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class FormEx6 : Form
    {
        public FormEx6()
        {
            InitializeComponent();
        }

        private void btnRendaTotal_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            double valorHora = Convert.ToDouble(txtValorHora.Text);
            int quantHoras = Convert.ToInt32(txtHorasTrabalhadas.Text);
            double resultado = valorHora * quantHoras;

            string mensagem = $"A renda total de {nome} é R$ {resultado}.";

            MessageBox.Show(mensagem, "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information );


        }
    }
}
