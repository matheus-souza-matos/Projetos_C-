// Adapte o programa abaixo para solicitar a idade do usuário. Se o usuário for maior de 18 anos exibir a mensagem maior de idade, do contrário exibir a mensagem menor de idade.

Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine()!);

if (idade >= 18)
{
    Console.WriteLine("Maior de idade");
}
else if (idade >= 16)
{
    Console.WriteLine("Você pode entrar com autorização");
}
else
{
    Console.WriteLine("Menor de idade");
}
