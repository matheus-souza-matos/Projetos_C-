// Tipos de dados

string nome = "Matheus"; // tipo texto
Console.WriteLine("O nome do usuário é: " + nome);

int idade = 22; // numeros inteiros
//console.WriteLine("A idade do usuário é: " + idade + " anos");
Console.WriteLine($"A idade do usuário é: {idade} anos");

float carteira = 2.63f; // números com vírgula

Char classificacao = 'A'; // tipo caractér
Console.WriteLine($"O cliente é do tipo {classificacao}");

bool dinheiroNaConta = true; // verdadeiro/falso - lógico
Console.WriteLine(dinheiroNaConta);

double limiteCredito = 2000.0; // número com vírgula
Console.WriteLine("Seu limite de crédito é: " + limiteCredito);

string sobrenome = " Matos";

string nomeCompleto = nome + sobrenome;
Console.WriteLine(nomeCompleto);

double valorConta = 53.73;
Console.WriteLine($"O valor na conta é: {valorConta}");

double limiteTotal = valorConta + limiteCredito;
Console.WriteLine($"O saldo + limite é {limiteTotal}");

