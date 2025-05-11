// Escreva um programa que pergunte a nota de um aluno. Se a nota for maior ou igual a 6, o aluno é considerado "Aprovado". Caso contrário, ele é "Reprovado". Exiba a situação do aluno na tela. 

Console.WriteLine("Digite a nota do aluno: ");
double nota = double.Parse (Console.ReadLine()!);
if (nota >= 6)
{
    Console.WriteLine("Aluno aprovado");
} else
{
    Console.WriteLine("Aluno reprovado");
}