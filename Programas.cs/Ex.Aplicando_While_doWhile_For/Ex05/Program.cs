//5. Um gerente de loja quer saber quantos produtos estão em estoque. O aluno deve solicitar que o usuário insira a quantidade de produtos recebidos e vendidos até que ele digite 0. Depois disso, o programa deve calcular a quantidade total de produtos em estoque, utilizando as três estruturas de repetição;

int totProdutosEstoque = 0;
int produtos = 0;
//int totalProdutos = produtoEstoque + produtos;

Console.WriteLine("Insira a quantidade de produtos em estoque ou digite '0' para encerrar e ver a quantidade total de produtos em estoque");

/*
while (true) //Inicio do loop
{
    produtos = Convert.ToInt32(Console.ReadLine()); //Recebe o que o usuário digitar
    if (produtos == 0) //verifica a condição, caso verdadeiro encerra o loop
        break;
    totProdutosEstoque += produtos; //variavel totProdutosEstoque recebe o total de produtos 
}
Console.WriteLine("A quantidade total de produtos em estoque é: " + totProdutosEstoque); //Imprime o total de produtos em estoque
*/

/*
do //inicia o loop
{
    produtos = Convert.ToInt32(Console.ReadLine());
    totProdutosEstoque += produtos;
}while (produtos != 0); //Encerra o loop quando condição for falsa
Console.WriteLine("A quantidade total de produtos em estoque é: " + totProdutosEstoque);
*/

/*
for (; ; ) //loop sempre verdadeiro
{
    produtos = Convert.ToInt32(Console.ReadLine());
    if (produtos == 0) //Encerra o loop caso condição for verdadeira
        break;
    totProdutosEstoque += produtos;
}
Console.WriteLine("A quantidade total de produtos em estoque é: " + totProdutosEstoque);
*/