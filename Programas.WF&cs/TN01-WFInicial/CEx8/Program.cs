namespace CEx8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalNum;

            Console.WriteLine("Calculadora ligada! digite dois números desejados e depois selecione a operação que deseja efetuar\n");
            Console.WriteLine("Primeiro número: ");
            double num1 = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Segundo número: ");
            double num2 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("escolha uma opção de operação: (digite o número correspondente a opção)");
            Console.WriteLine("1 - Soma.\n2 - Subtração.\n3 - Multiplicação.\n4 - Divisão.\n5 - Potenciação.\n6 - Radiciação.");
            int opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    totalNum = num1 + num2;
                    Console.WriteLine("A soma entre os números selecionados é: " + totalNum);
                break;

                case 2:
                    totalNum = num1 - num2;
                    Console.WriteLine("A subtração entre os números selecionados é: " + totalNum);
                break;

                case 3:
                    totalNum = num1 * num2;
                    Console.WriteLine("A multiplicação entre os números selecionados é: " + totalNum);
                break;

                case 4:
                    if (num1 == 0 || num2 == 0)
                    {
                        Console.WriteLine("Divisão inválida");
                    }
                    else
                    {
                        totalNum = num1 / num2;
                        Console.WriteLine("A divisão entre os números selecionados é: " + totalNum);
                    }
                break;
                case 5:
                    totalNum = Math.Pow(num1,num2);
                    Console.WriteLine("A potenciação entre os números selecionados é: " + totalNum);
                break;

                case 6:
                    if (num1 < 0)
                    {
                        Console.WriteLine("Não é possível calcular uma raiz de um número negativo");
                    }
                    else
                    {
                        totalNum = Math.Sqrt(num1);
                        Console.WriteLine("A radiação do número " + num1 + " é: " + totalNum);
                    }

                break;

                default:
                    Console.WriteLine("Alternativa válida");
                break;        

            }
        }
    }
}
