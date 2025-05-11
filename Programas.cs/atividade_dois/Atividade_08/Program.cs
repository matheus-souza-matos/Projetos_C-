// Crie um programa que pergunte a idade de uma pessoa e determine se ela pode votar (idade >= 16). Utilize uma condição if para exibir a mensagem correspondente. 

Console.WriteLine("Digite a sua idade para sabermos se você pode votar: ");
int idade = int.Parse(Console.ReadLine()!);
if (idade >= 16)
{
    Console.WriteLine("Você pode votar");
} else
{
    Console.WriteLine("Você não pode votar");
}