// Crie um programa que solicite ao usuário um número e imprima todos os números de 1 até o número informado usando um laço `while`.

Console.WriteLine("Digite um número: ");

int numero = int.Parse(Console.ReadLine());
int contador = 10;

do
{
    Console.WriteLine(contador);
    contador -= 2; // decrementando o contador em 2
}

while (contador >= numero);
{

}
