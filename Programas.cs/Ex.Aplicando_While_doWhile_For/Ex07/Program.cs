// 7. Um ciclista deseja saber a distância total que percorreu. Para isso, o aluno deve solicitar que o usuário insira as distâncias percorridas em cada dia até que um valor negativo seja digitado. A soma das distâncias deve ser calculada e exibida utilizando as três estruturas de repetição;

double distanciaPercorrida = 0;
double distanciaTotal = 0;
int contadorDias = 1;

/*
while (distanciaPercorrida >= 0) //inicia o loop e repete ENQUANTO distanciaPercorrida for maior ou IGUAL a '0'
{
    Console.WriteLine("Digite a distância percorrida no dia " + contadorDias + " ou digite um número negativo para encerrar e ver a distância total percorrida: "); //imprime para o usuário 
    distanciaPercorrida = Convert.ToDouble(Console.ReadLine()); //lê o que o usuário digitar
    if (distanciaPercorrida >= 0) //condição para incrementar apenas os números maires ou iguais a '0' para não subtrair o número negativo de encerramento a distância total final
    {
        distanciaTotal += distanciaPercorrida; // distanciaTotal recebe o que o usuário digitou e soma para dar o total
        contadorDias++; //acrescenta +1 na variável para indicar os dias
    }
}
contadorDias--; //subtrai -1 do número de dias para a opção de encerramento não contar como dia percorido.
Console.WriteLine("A soma das distâncias de " + contadorDias + " dias percorridos é: " + distanciaTotal); //imprime para o usuário os dias e a distancia total percorrida
*/

/*
do //inicia o loop
{
    Console.WriteLine("Digite a distância percorrida no dia " + contadorDias + " ou digite um número negativo para encerrar e ver a distância total percorrida: ");

    distanciaPercorrida = Convert.ToDouble(Console.ReadLine());

    if (distanciaPercorrida >= 0)
    {
        distanciaTotal += distanciaPercorrida;
        contadorDias++;
    }

} while (distanciaPercorrida >= 0); //repete o loop ENQUANTO distanciaPercorrida for maior ou IGUAL a '0'
contadorDias--;
Console.WriteLine("A soma das distâncias de " + contadorDias + " dias percorridos é: " + distanciaTotal);
*/

/*
for (; ; ) //loop verdadeiro
{
    Console.WriteLine("Digite a distância percorrida no dia " + contadorDias + " ou digite um número negativo para encerrar e ver a distância total percorrida: ");

    distanciaPercorrida = Convert.ToDouble(Console.ReadLine());

    if (distanciaPercorrida < 0) //condição para encerrar o loop caso seja verdadeiro
        break;

    if (distanciaPercorrida >= 0)
    {
        distanciaTotal += distanciaPercorrida;
        contadorDias++;
    }
}
contadorDias--;
Console.WriteLine("A soma das distâncias de " + contadorDias + " dias percorridos é: " + distanciaTotal);
*/