// 10. Um vendedor de passagens deseja saber quantas passagens ele vendeu em um dia. O aluno deve pedir ao usuário para inserir o valor das passagens vendidas até que ele digite um valor negativo. O total de passagem vendidas deve ser calculado e apresentado utilizando while, do while e for;

double valorPassagem;
int passagemVendida = 0;

Console.WriteLine("Digite o valor de cada passagem vendida, e após finalizar insira um número negativo para ver o total de vendas: "); //escreve para o usuário em todas as estruturas de repetição

/*
while (true) //loop verdadeiro
{
    valorPassagem = Convert.ToDouble(Console.ReadLine()); //lê o que o usuário digitar
    if (valorPassagem < 0 ) //condição para encerrar loop caso seja verdadeiro valor digitado menor que '0'
        break;
    if (valorPassagem >= 0) //condição para continuar o loop e incrementar +1 na quantidade de passagens vendidas
        passagemVendida++; //acrescenta +1 na variavel passagemVendida caso if seja verdadeiro
}
Console.WriteLine("Você vendeu um total de " + passagemVendida + " passagens."); //mostra para o usuário o total de passagens vendidas
*/

/*
do //inicia o loop
{
    valorPassagem = Convert.ToDouble(Console.ReadLine());
    if (valorPassagem >= 0) //acrescenta +1 na váriavel caso condição seja verdadeira
        passagemVendida++;
}while(valorPassagem >= 0); //repete o loop ENQUANTO valorPassagem for maior ou IGUAL a '0'
Console.WriteLine("Você vendeu um total de " + passagemVendida + " passagens."); //imprimi para o usuário o total de passagens vendidas
*/

/*
for (; ; ) //loop verdadeiro
{
    valorPassagem = Convert.ToDouble(Console.ReadLine());
    if (valorPassagem < 0) //encerra o loop caso seja verdadeira a condição
        break;
    if (valorPassagem >= 0) //continua o loop caso seja verdadeiro a condição
        passagemVendida++; //acrescenta +1 na variavel
}
Console.WriteLine("Você vendeu um total de " + passagemVendida + " passagens."); //imprimi para o usuário o total de passagens vendidas
*/