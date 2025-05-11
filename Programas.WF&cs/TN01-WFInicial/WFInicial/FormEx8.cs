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
    public partial class FormEx8 : Form
    {
        public FormEx8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double primeiroNumero = double.Parse(txtNum1.Text);
            double segundoNumero = double.Parse(txtNum2.Text);
            double resultado = primeiroNumero + segundoNumero;

            string message = $"A soma dos números {primeiroNumero} e {segundoNumero} é: {resultado} ";

            MessageBox.Show(message, "Resultado:",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            double primeiroNumero = double.Parse(txtNum1.Text);
            double segundoNumero = double.Parse(txtNum2.Text);
            double resultado = primeiroNumero - segundoNumero;

            string message = $"A subtração dos números {primeiroNumero} e {segundoNumero} é: {resultado} ";

            MessageBox.Show(message, "Resultado:",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            double primeiroNumero = double.Parse(txtNum1.Text);
            double segundoNumero = double.Parse(txtNum2.Text);
            double resultado = primeiroNumero * segundoNumero;

            string message = $"A multiplicação dos números {primeiroNumero} e {segundoNumero} é: {resultado} ";

            MessageBox.Show(message, "Resultado:",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            double primeiroNumero = double.Parse(txtNum1.Text);
            double segundoNumero = double.Parse(txtNum2.Text);
            double resultado = primeiroNumero / segundoNumero;

            if (primeiroNumero == 0 || segundoNumero == 0)
            {
                MessageBox.Show("Divisão inválida!", "Error:",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string message = $"A divisão dos números {primeiroNumero} e {segundoNumero} é: {resultado} ";

                MessageBox.Show(message, "Resultado:",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPotenciacao_Click(object sender, EventArgs e)
        {
            double primeiroNumero = double.Parse(txtNum1.Text);
            double segundoNumero = double.Parse(txtNum2.Text);
            double resultado = Math.Pow(primeiroNumero, segundoNumero);

            string message = $"A Potenciação do número {primeiroNumero} elevado a {segundoNumero} é: {resultado} ";

            MessageBox.Show(message, "Resultado:",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRadiacao_Click(object sender, EventArgs e)
        {
            double primeiroNumero = double.Parse(txtNum1.Text);
            double segundoNumero = double.Parse(txtNum2.Text);
            double resultado = Math.Pow(primeiroNumero, segundoNumero);

            if (segundoNumero == 0)
                    resultado = 1;
                else
                    resultado = Math.Pow(primeiroNumero, (1 / segundoNumero));
                string mensagem = $"A Raiz de {primeiroNumero} ^ {segundoNumero} = {resultado}";
                MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
