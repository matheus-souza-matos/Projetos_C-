// 4. Um grupo de amigos deseja calcular a idade média deles. Para isso, o aluno deve pedir que o usuário insira as idades e calcule a média até que o usuário digite 0. A solução deve ser implementada usando while, do while e for;


int idade, somaIdade = 0, contador = 0;
double idadeMedia;

Console.WriteLine("Digite a idade ou '0' para ver a média entre as idade: ");

/*
while (true) // Inicio do loop
{
    idade = Convert.ToInt32(Console.ReadLine()); // recebe o que o usuário digitar
    if (idade == 0) // verifica a condição se é verdadeira e caso seja, encerra o loop
        break;
    somaIdade += idade; // armazena as informações, e soma sempre com o número anterior digitado;
    contador++; // adiciona +1 a cada giro do loop
}
idadeMedia = somaIdade / contador; // divide o valor das indade com a quantidade de pessoas e entrega a média
Console.WriteLine("A média de idade é: " + idadeMedia); //Imprime a média de idades
*/

/*
do //Inicia o loop
{
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade != 0) //Verifica a condição, se idade for diferente de '0', ele roda a condição if
    {
        somaIdade += idade; //armazena as informações, e soma sempre com o número anterior digitado;
        contador++; //adiciona +1 a cada giro do loop
    }
}while (idade != 0); // encerra o loop até o usuário digitar '0'
idadeMedia = somaIdade / contador;
Console.WriteLine("A média de idades é: " + idadeMedia);
*/

/*
for (; ; ) //loop sempre verdadeiro
{
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade == 0)
        break;
    somaIdade += idade;
    contador++;
}
idadeMedia = somaIdade / contador;
Console.WriteLine("A média de idade é: " + idadeMedia);
*/