// 9. Um cliente deseja saber o total de suas compras em um supermercado. o aluno deve solicitar que o usuário insira o valor de cada compra até que ele digite 0. A soma dos valores das compras deve ser implementada usando as três estruturas de repetição;

double valorCompra;
double totalCompras = 0;

Console.WriteLine("Digite para mim o valor de cada ítem, ou pressione '0' para ver o valor total: "); //escreve para o usuário em todas as estruturas de repetição
/*
while (true) //loop verdadeiro
{
    valorCompra = Convert.ToDouble(Console.ReadLine()); //lê o que o usuário digitar
    if (valorCompra == 0) //condição verdadeira encerra o loop (verifica resposta do usuário)
        break;
    if (valorCompra != 0) //condição verdadeira continua o loop
    {
        totalCompras += valorCompra; //variavel totalCompras recebe o que o usuário digitar e soma tudo
    }
}
Console.WriteLine("O valor total de sua compra é: " + totalCompras); //imprimi o valor total de compras quando o usuário digita '0'
*/

/*
do //inicia o loop
{
    valorCompra = Convert.ToDouble(Console.ReadLine());
    totalCompras += valorCompra;
} while (valorCompra != 0); //repete o loop ENQUANTO valor digitado pelo usuário seja diferente de '0'
Console.WriteLine("O valor total de sua compra é: " + totalCompras); //imprimi para o usuário o total de compras
*/

/*
for (; ; ) //loop verdadeiro
{
    valorCompra = Convert.ToDouble(Console.ReadLine());
    if (valorCompra == 0)
        break;
    if (valorCompra != 0)
    {
        totalCompras += valorCompra;
    }
}
Console.WriteLine("O valor total de sua compra é: " + totalCompras);
*/