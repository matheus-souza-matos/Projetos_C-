// Se o total de quilômetros por litro for maior que 9 exibir a mensagem: "Carro econômico", se consumo médio entre 6,5 e 9 exibir "consumo mediano", abaixo de 6,5 exibir a mensagem: "Carro com consumo alto". Você não deve apagar nenhuma linha escrita até então. Exceto se for melhorar o exercício


Console.WriteLine("Qual a quantidade em litros abastecido? ");
int litrosAbastecidos = int.Parse(Console.ReadLine()!);

Console.WriteLine("Qual a quantidade de quilômetros percorridos até o término da viagem? ");
int quilometros = int.Parse(Console.ReadLine()!);

int total = quilometros / litrosAbastecidos;

Console.WriteLine("A quantidade de quilômetros pro litro percorrido é: " + total);

if (total > 9)
{
    Console.WriteLine("Carro econômico");
}else if (total >= 6.5 && total <= 9){
    Console.WriteLine("Consumo mediano");
}else
{
    Console.WriteLine("Carro com alto consumo");
}
