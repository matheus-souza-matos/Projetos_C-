// 1. Um funcionário deseja contar quantos dias de trabalho ele teve em um mês. Para isso, ele deve inserir os dias trabalhados {de 1 a 31} até que digite 0, que indica que terminou de informar os dias. O aluno deve implementar essa contagem utilizando as estruturas de repetição while, do while e for.

int diasTrabalhados = 0;
Console.WriteLine("Digite os dias trabalhados ou digite (0) para sair e ver o total de dias trabalhados");

/*
int dia = int.Parse(Console.ReadLine()); // lê o que o usuário digitar e valida a condição do while;
while (dia != 0) // condição do loop (enquanto dia for diferente de '0', faça isso.
{
    dia = Convert.ToInt32(Console.ReadLine()); // lê o que o usuário digitar até o mesmo digitar '0'
    diasTrabalhados++; // acrescenta +1 a cada repetição do loop e armazena na variável diasTrabalhados
}
Console.WriteLine("Total de dias trabalhados: " + diasTrabalhados); // imprime para o usuário a quantidade de dias trabalhados.
*/

/*
int dia; // variável sem valor para não encerrar o loop
do
{
    dia = Convert.ToInt32(Console.ReadLine()); // lê o que o usuário digitou e verifica se é ou não diferente de '0'
    if (dia != 0) // condição para o loop acrescentar +1 nos dias trabalhados.
    {
        diasTrabalhados++; // "++" acrescenta +1
    }
}
while (dia != 0); // verifica a informação digitada e encerra o ciclo.
Console.WriteLine("Total de dias trabalhados: " + diasTrabalhados); // imprime para o usuário a quantidade de dias trabalhados.
*/

/*
int dia = 0; // variável para o usuário digitar os dias que trabalhou
for (; ; ) // loop verdadeiro - não há inicialização, o código é lido e caso não tenha outra condição, se torna infinito o loop
{
    dia = Convert.ToInt32(Console.ReadLine()); // lê o que o usuário digitar até o mesmo digitar '0'
    if (dia == 0) // condição para encerrar o loop caso o usuário digite '0'
        break;
    if (dia != 0) // condição para fazer a incrementação em diasTrabalhados caso o número seja diferente de '0'
    {
        diasTrabalhados++; // acrescenta +1 a cada repetição do loop e armazena na variável diasTrabalhados
    }

}
Console.WriteLine("Total de dias trabalhados: " + diasTrabalhados); // imprime para o usuário a quantidade de dias trabalhados.
*/