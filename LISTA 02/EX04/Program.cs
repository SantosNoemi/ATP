//variável
int idade;

//entrada
Console.WriteLine("Digite a idade de uma pessoa: ");
idade = int.Parse(Console.ReadLine());

//processamento e saída
if (idade >= 0 && idade <= 12)
    Console.WriteLine("Criança");
else if (idade >= 13 && idade <= 17)
    Console.WriteLine("Adolescente");
else if (idade >= 18 && idade <= 64)
    Console.WriteLine("Adulto");
else
    Console.WriteLine("Idoso");