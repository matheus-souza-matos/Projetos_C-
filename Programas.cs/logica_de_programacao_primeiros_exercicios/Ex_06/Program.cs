// Solicitar 2 números ao usuário e realizar texte lógico (

Console.WriteLine("N1");
double n1 = double.Parse(Console.ReadLine());

Console.WriteLine("N2");
double n2 = double.Parse(Console.ReadLine());

Console.WriteLine($"N1 é maior que N2? Resposta: {n1 > n2}");
Console.WriteLine($"N1 é maior ou igual que N2? Resposta: {n1 >= n2}");
Console.WriteLine($"N1 é menor que N2? Resposta: {n1 < n2}");
Console.WriteLine($"N1 é menor ou igual que N2? Resposta: {n1 <= n2}");
Console.WriteLine($"N1 é igual N2? Resposta: {n1 == n2}");
Console.WriteLine($"N1 ou N2 é maior que zero? Resposta: {n1 > 0 || n2 > 0}");
Console.WriteLine($"N1 e N2 é maior que zero? Resposta: {n1 > 0 && n2 > 0}");
