using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFInicial
{
    public partial class FormEx2 : Form
    {
        public FormEx2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            byte opcao = byte.Parse(txtDiaSemana.Text);

            switch (opcao)
            {
                case 1:
                    MessageBox.Show("Domingo","Dia da semana",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    break;
                case 2:
                    MessageBox.Show("Segunda-feira","Dia da semana",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    break;
                case 3:
                    MessageBox.Show("Terça-feira", "Dia da semana", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Asterisk);
                    break;
                case 4:
                    MessageBox.Show("Quarta-feira", "Dia da semana", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Asterisk);
                    break;
                case 5:
                    MessageBox.Show("Quinta-feira", "Dia da semana", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Asterisk);
                    break;
                case 6:
                    MessageBox.Show("Sexta-feira", "Dia da semana", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Asterisk);
                    break;
                case 7:
                    MessageBox.Show("Sabado", "Dia da semana", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Asterisk);
                    break;
                default:
                    MessageBox.Show("Opção inválida!", "Erro", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                    break;
            }
        }

        private void FormEx2_Load(object sender, EventArgs e)
        {

        }
    }
}
