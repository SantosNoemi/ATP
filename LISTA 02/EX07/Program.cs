//Variável
double F, C;

//Entrada de dados
Console.WriteLine("DIgite a temperatura: ");
F = double.Parse(Console.ReadLine());

//Processamento e saída de dados
C = (F - 32) * 5 / 9;
if (C < 0)
    Console.WriteLine("Está muito frio!");
else if (C >= 0 && C <= 30)
    Console.WriteLine("O clima está agradável.");
else
    Console.WriteLine("Está muito quente!");

