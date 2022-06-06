double N;

Console.Write("Digite a sua nota: ");
N=double.Parse(Console.ReadLine());

if (N<5)
{
    Console.WriteLine("Aluno reprovado");
}
if (N>=5 && N<7)
{
    Console.WriteLine("Aluno de recuperação");
}
if (N>=7)
{
    Console.WriteLine("Aluno aprovado");
}