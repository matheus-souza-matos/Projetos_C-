// Se o usuário tiver até 10 anos, aparecer a mensagem você é uma criança, entre 10 e 14 você é um pré adolecente, entre 15 e 17 você é um adolecente, entre 18 e 60 você é um adulto. maiores que 60, você é está na melhor idade. Você não deve apagar nenhum código abaixo.

Console.WriteLine("Digite o seu nome completo: ");
string nome = Console.ReadLine()!;

Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine()!);

/*if (idade >= 18)
{
    Console.WriteLine("Usuário " + nome + " você é maior de idade: " + idade);
}
else if (idade >= 16)
{
    Console.WriteLine("Usuário " + nome + " você pode entrar com autorização: " + idade);
}
else
{
    Console.WriteLine("Usuário " +nome+" você é menor de idade: " + idade);
}*/


if (idade >0 && idade <= 10)
{
    Console.WriteLine("Usuário " + nome + " você é uma criança: " + idade);
}
else if (idade > 10 && idade <= 14)
{
    Console.WriteLine("Usuário " + nome + " você é pré adolecente: " + idade);
}
else if (idade >= 15 && idade <= 17)
{
    Console.WriteLine("Usuário " + nome + " você é adolecente: " + idade);
}
else if (idade >= 18 && idade <= 60)
{
    Console.WriteLine("Usuário " + nome + " você é um adulto: " + idade);
}
else if (idade > 60)
{
    Console.WriteLine("Usuário " + nome + "Você está na melhor idade: " + idade);
}
else
{
    Console.WriteLine("Idade inválida, favor informar idade correta");
}
