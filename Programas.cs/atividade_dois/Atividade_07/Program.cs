// Escreva um programa que solicita dois números ao usuário e determina qual deles é maior. Utilize if, else if e else para exibir a mensagem adequada. 

Console.WriteLine("Digite o Primeiro número: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Digite o Segundo número: ");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 > num2)
{
    Console.WriteLine("O primeiro número é maior");
} else if (num1 < num2)
{
    Console.WriteLine("O Segundo número é maior");
} else
{
    Console.WriteLine("Os dois número são iguais");
}