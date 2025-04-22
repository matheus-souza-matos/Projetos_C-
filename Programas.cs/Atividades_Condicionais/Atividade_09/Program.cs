// Desenvolva um programa que peça um número de 1 a 7 e exiba o dia da semana correspondente (1 para "Domingo", 2 para "Segunda-feira", etc.). Se o número estiver fora desse intervalo, exiba uma mensagem de erro. 

Console.WriteLine("Digite um número de 1 a 7: ");
int numero = int.Parse(Console.ReadLine()!);
if (numero == 1)
{
    Console.WriteLine("Domingo");
}
else if (numero == 2)
{
    Console.WriteLine("Segunda");
}
else if (numero == 3)
{
    Console.WriteLine("Terça");
}
else if (numero == 4)
{
    Console.WriteLine("Quarta");
}
else if (numero == 5)
{
    Console.WriteLine("Quinta");
}
else if (numero == 6)
{
    Console.WriteLine("Sexta");
}
else if (numero == 7)
{
    Console.WriteLine("Sabado");
}
else
{
    Console.WriteLine("Número inválido, por favor digite um número de 1 a 7");
}