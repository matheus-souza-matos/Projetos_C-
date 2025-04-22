// Escreva um programa que solicite a um usuário a quantidade em litros abastecidos em um automóvel. Em seguida o programa deve solicitar que o usuário informe a quantidade de quilômetros percorridos até o término do tanque. O programa deve exibir a quantidade de quilometros por litro.


Console.WriteLine("Qual a quantidade em litros abastecido? ");
int litrosAbastecidos = int.Parse(Console.ReadLine()!);

Console.WriteLine("Qual a quantidade de quilômetros percorridos até o término da viagem? ");
int quilometros = int.Parse(Console.ReadLine()!);

int total = quilometros / litrosAbastecidos;

Console.WriteLine("A quantidade de quilômetros pro litro percorrido é: " + total);
