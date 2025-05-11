namespace CEx7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produtoMaisBarato = "";
            double valorMaisBarato = double.MaxValue;


            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine($"Digite o {i}º produto: ");
                string produto = Console.ReadLine();

                Console.WriteLine($"Digite o valor do produto {i}: ");
                double valor = double.Parse(Console.ReadLine());

                if (valor < valorMaisBarato)
                {
                    valorMaisBarato = valor;
                    produtoMaisBarato = produto;
                }

            }
            Console.Write($"o produto mais barato é:\n{produtoMaisBarato}, no valor de: {valorMaisBarato}");
        }
    }
}