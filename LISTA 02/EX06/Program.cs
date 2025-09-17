//Variaveis
string aluno;
double nota1, nota2, nota3, media;

//Entrada de dados
Console.WriteLine("Informe o nome do aluno: ");
aluno = Console.ReadLine();
Console.WriteLine("Insira a primeira nota do aluno: ");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a segunda nota do aluno: ");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a terceira nota do aluno: ");
nota3 = double.Parse(Console.ReadLine());

//Processamento de dados
media = (nota1 + nota2 + nota3) / 3;

if (media >= 7)
    Console.WriteLine($"{aluno} aprovado(a)!");
else if (media >= 5 || media < 7)
    Console.WriteLine($"{aluno} está de recuperação '-'.");
else
    Console.WriteLine($"{aluno} reprovado(a) ;-;.");