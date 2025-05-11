namespace CEx5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o 1º número: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write("Digite o 2º número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 3º número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int maior = Math.Max(num1, num2);
            maior = Math.Max(maior, num3);
            
            int menor = Math.Min(num1, num2);
            menor = Math.Min(menor, num3);

            Console.WriteLine($"\nO número {maior} é o maior valor!");
            Console.WriteLine($"\nO número {menor} é o menor valor!");
        }
    }
}
