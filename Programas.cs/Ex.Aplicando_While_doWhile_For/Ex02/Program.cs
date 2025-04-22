// 2. Um usuário quer calcular suas despesas mensais. O exercício consiste em solicitar ao usuário que insira suas despesas, até que ele digite um valor negativo, sinalizando o fim da entrada. O aluno deve somar as despesas e apresentar o total, utilizando while, do while e for.

double despesas, total = 0;
Console.WriteLine("Digite suas despesas mensais, e para sair digite um número negativo e veja o total de despesas: ");

/*
while (true) // inicia o loop verdadeiro (true)
{
    despesas = Convert.ToDouble(Console.ReadLine()); // Lê o que o usuário digitar e guarda na variável despesas (double)
    if (despesas < 0) //verifica se despesas é verdadeiro ou falso - caso verdadeiro faça break (encerra loop)
        break;
    total += despesas; //variável total recebe soma das despesas
}
Console.WriteLine("O valor total de suas despesas mensais é: " + total); //imprime para o usuário o total de despesas
*/

/*
do // início do loop
{
    despesas = Convert.ToDouble(Console.ReadLine());
    if (despesas >= 0) //verifica se despesas é verdadeiro ou falso - caso verdadeiro faça total receber soma de despesas.
    {
        total += despesas;//variável total recebe soma das despesas até if ser falso
    }
}while (despesas >= 0); //Encerra o loop caso seja falso (despesa menor que 0)
Console.WriteLine("O valor total de suas despesas mensais é: " + total); //imprime para o usuário o total de despesas
*/

/*
for (; ;) // loop verdadeiro (;;) - loop infinito caso não tenha condição
{
    despesas = Convert.ToDouble(Console.ReadLine());
    if (despesas < 0) //verifica se despesas é verdadeiro ou falso - caso verdadeiro faça break (encerra loop)
        break;
    total += despesas; //variável total recebe soma das despesas
}
Console.WriteLine("O valor total de suas despesas mensais é: " + total); //imprime para o usuário o total de despesas
*/
