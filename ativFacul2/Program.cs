double N;

Console.Write("Digite a sua nota: ");
N = double.Parse(Console.ReadLine());

var result = N > 5 ? "Aluno aprovado" : "Aluno reprovado";
Console.WriteLine(result);

