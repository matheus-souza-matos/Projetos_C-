// 3. Uma escola deseja saber quantos alunos foram aprovados em uma disciplina. O aluno deverá solicitar que o usuário insira as notas dos alunos (de 0 a 10) e, ao digitar -1, encerrará a entrada. Em seguida, deve contar quantos alunos tiveram nota maior ou igual a 6, utilizando as três estruturas de repetição.

int alunosAprovados = 0;
double nota;

/*
while (true) //inicia o loop verdadeiro
{
    Console.WriteLine("Digite a nota do aluno ou digite '-1' para finalizar e ver a quantidade de aprovados: "); //texto inicial
    nota = Convert.ToDouble(Console.ReadLine()); //Lê o que o usuário digitar
    if (nota >= 6 && nota <= 10) //condição verdadeiro ou falso - análisa duas condições >=6 'E' (&&) <=10
    {
        alunosAprovados++; //condição sendo verdadeira, acrescenta +1 na variável alunosAprovados
    }
    if (nota == -1) //se condição verdadeira, o loop se encerra
        break; // comando para encerra o loop
}
Console.WriteLine("O total de alunos aprovados com nota maior ou igual a 6 é: " + alunosAprovados); //imprime após encerramento do loop o total de aluno aprovado.
*/

/*
do //inicio o loop
{
    Console.WriteLine("Digite a nota do aluno ou digite '-1' para finalizar e ver a quantidade de aprovados: "); //texto p/ usuário ler
    nota = Convert.ToDouble(Console.ReadLine()); //Lê o que o usuário digita e armazena na variável;
    if (nota >= 6 && nota <= 10) //verifica a condição através da resposta do usuário;
    {
        alunosAprovados++; // se verdadeiro incrementa;
    }
} while (nota >= 0); //fim do loop se o usuário digitar um número que não seja de 0 a 10
Console.WriteLine("O total de alunos aprovados com nota maior ou igual a 6 é: " + alunosAprovados); //Imprime o total de alunos aprovados
*/

/*
for (; ; ) // loop sempre verdadeiro (; ;) 
{
    Console.WriteLine("Digite a nota do aluno ou digite '-1' para finalizar e ver a quantidade de aprovados: ");
    nota = Convert.ToDouble(Console.ReadLine());
    if (nota >= 6 && nota <= 10)
    {
        alunosAprovados++;
    }
    if (nota == -1) //Encerra o loop após o usuário digitar '-1" - condição verdadeira
        break;
}
Console.WriteLine("O total de alunos aprovados com nota maior ou igual a 6 é: " + alunosAprovados);
*/

