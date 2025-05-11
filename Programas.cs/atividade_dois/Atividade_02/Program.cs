// Desenvolva um programa que solicita ao usuário um número. O programa deve determinar se o número é positivo, negativo ou zero, utilizando if, else if, e else para as três possibilidades. Exiba a mensagem correspondente. 

Console.WriteLine("Digite um número e descubra se ele é positivo, negativo ou zero: ");
int numero = int.Parse(Console.ReadLine()!);
if (numero > 0)
{
    Console.WriteLine("O número é positivo. ");
} else if (numero < 0)
{
    Console.WriteLine("O número é negativo");
}else
{
    Console.WriteLine("O número é zero");
}
