// Escreva um programa que solicite o primeiro nome do usuário em seguida solicitar o sobrenome do usuário. O programa deve apresentar uma mensagem de boas vindas e o nome completo do usuário

Console.WriteLine("Escreva seu nome: ");
string nome = Console.ReadLine()!;

Console.WriteLine("Escreva seu sobrenome: ");
string sobrenome = Console.ReadLine()!;

Console.WriteLine("Seja bem vindo " + nome + sobrenome);
