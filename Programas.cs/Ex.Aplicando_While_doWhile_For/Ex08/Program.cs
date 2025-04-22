// 8. Um atendente de suporte técnico deseja contar quantas chamadas atendeu em um dia. O aluno deverá pedir ao usuário que insira o tempo de duração de cada chamada em minutos até que ele digite 0. O programa deve calcular o total de minutos atendidos, utilizando while, do while e for;

int totalChamadas;
double duracaoChamada;
double totMinutos = 0;
int contadorChamadas = 0;

Console.WriteLine("Insira o tempo de duração de cada chamada recebida em minutos ou pressione '0' para encerrar e ver o total de minutos: "); //imprime para o usuário em todas as estruturas de repetição

/*
while (true) //loop verdadeiro
{
    duracaoChamada = Convert.ToDouble(Console.ReadLine()); //lê o que o usuário digitar
    if (duracaoChamada == 0) //condição para encerrar o loop caso seja verdadeiro
        break;
    if (duracaoChamada != 0) //condição para permanecer no loop caso seja verdadeiro a informação
    {
        totMinutos += duracaoChamada; //atribui o que o usuário digitar em totMinutos e soma mais o próximo valor
        contadorChamadas++; //acrescenta +1 na variavel para mostrar os dias para o usuário
    }
}
Console.WriteLine("O total chamadas atendidas durante o dia foi " + contadorChamadas + " e a quantidade total de minutos foi de: " + totMinutos); //imprimi a quantidade total de dias e distância percorrida nesses dias
*/

/*
do //inicia o loop
{
    duracaoChamada = Convert.ToDouble(Console.ReadLine());

    if (duracaoChamada != 0)
    {
        totMinutos += duracaoChamada;
        contadorChamadas++;
    }
} while (duracaoChamada != 0); //repete o loop ENQUANTO duracaoChamada for diferente de '0'
Console.WriteLine("O total chamadas atendidas durante o dia foi " + contadorChamadas + " e a quantidade total de minutos foi de: " + totMinutos);
*/

/*
for (; ; ) //loop verdadeiro
{
    duracaoChamada = Convert.ToDouble(Console.ReadLine());
    if (duracaoChamada == 0)
        break;
    if (duracaoChamada != 0)
    {
        totMinutos += duracaoChamada;
        contadorChamadas++;
    }
}
Console.WriteLine("O total chamadas atendidas durante o dia foi " + contadorChamadas + " e a quantidade total de minutos foi de: " + totMinutos);
*/