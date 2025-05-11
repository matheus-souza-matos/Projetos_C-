namespace ConsoleRevisaoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a 1º nota do aluno: ");
            double nota1 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite a 2º nota do aluno: ");
            double nota2 = double.Parse(Console.ReadLine()!);

            double media = (nota1 + nota2) / 2;

            if (media >= 7) 
            {
                Console.WriteLine("Aprovado. ");
            }
            else if (media < 5)
            {
                Console.WriteLine("Reprovado! ");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }

        }
    }
}
//olá
