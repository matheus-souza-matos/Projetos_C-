namespace WFInicial
{
    public partial class FormEx1 : Form
    {
        public FormEx1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtNota1.Text);
            double nota2 = double.Parse(txtNota2.Text);

            double media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                MessageBox.Show( //faz aparecer a caixa box com as mensagens conforme escrito abaixo.
                    "Aprovado", // texto informativo
                    "OK", // titulo da caixa
                    MessageBoxButtons.OK,// texto do botão
                    MessageBoxIcon.Information ); // simbolo
                Console.WriteLine("Aprovado");
            }
            else if (media < 5)
            {
                MessageBox.Show(
                    "Reprovado",
                    "Deu Ruim",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Console.WriteLine("Reprovado");
            }
            else
            {
                MessageBox.Show(
                    "Recuperação",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                Console.WriteLine("Recuperação");
            }
        }
    }
}
