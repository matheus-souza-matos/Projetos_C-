// 6. Durante uma eleição, um mesário deve contar os votos. O aluno deverá pedir ao usuário para inserir os votos (1 para candidato A, 2 para candidato B) até que ele digite 0. O programa deve contar quantos votos cada candidato recebeu, implementando a solução com while, do while e for;


int voto, candidatoA = 0, candidatoB = 0;
Console.WriteLine("Insira os votos (1 para o candidato A e 2 para o candidato B) ou pressione '0' para ver o resultado: ");

/*
while (true) // inicio do loop - loop verdadeiro
{
    voto = Convert.ToInt32(Console.ReadLine()); //lê o que o usuário digitar
    if (voto == 0) //condição para verificar a resposta do usuário
        break; // caso condição verdadeira, encerra o loop
    if (voto == 1) //condição de verificação de voto para candidato A
    {
        candidatoA++; //se verdadeiro candidatoA recebe +1
    }else if (voto == 2) //condição de verificação de voto para candidato B
    {
        candidatoB++; //se verdadeiro candidatoB recebe +1
    }else //condição caso nenhuma das anteriores seja verdadeira - recebe todo o resto
    {
        Console.WriteLine("Candidato não existente, favor insira 1 para o candidato A e 2 para o candidato B "); // imprime para o usuário a mensagem e retorna ao loop outra vez
    }
}
Console.WriteLine("A quantidade de votos de cada canditado é: \nCANDIDATO A: " + candidatoA + "\nCANDIDATO B: " + candidatoB); //imprime o resultado de votos de cada candidato - '\n' usado para pular linha
*/

/*
do //inicia o loop
{
    voto = Convert.ToInt32(Console.ReadLine());
    if (voto == 1)
    {
        candidatoA++;
    }
    else if (voto == 2)
    {
        candidatoB++;
    }
    else
    {
        Console.WriteLine("Candidato não existente, favor insira 1 para o candidato A e 2 para o candidato B ");
    }
}while (voto != 0); //repete o loop ENQUANTO voto for diferente de '0', encerra quando for o contrário
Console.WriteLine("A quantidade de votos de cada canditado é: \nCANDIDATO A: " + candidatoA + "\nCANDIDATO B: " + candidatoB);
*/

/*
for (; ; ) //condição verdadeira
{
    voto = Convert.ToInt32(Console.ReadLine());
    if (voto == 0)
        break;
    if (voto == 1)
    {
        candidatoA++;
    }
    else if (voto == 2)
    {
        candidatoB++;
    }
    else
    {
        Console.WriteLine("Candidato não existente, favor insira 1 para o candidato A e 2 para o candidato B ");
    }
}
Console.WriteLine("A quantidade de votos de cada canditado é: \nCANDIDATO A: " + candidatoA + "\nCANDIDATO B: " + candidatoB);
*/