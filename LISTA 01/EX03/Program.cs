//Declarando variáveis
double baseMenor, baseMaior, altura, area;

//Entrada de dados para encontrar a área do trapézio
Console.WriteLine("Insira os valores respectivos da base menor, base maior e altura do trapézio para encontrar a área: ");
baseMenor = double.Parse(Console.ReadLine());
baseMaior = double.Parse(Console.ReadLine());
altura = double.Parse(Console.ReadLine());

//Formula (base maior + base menor) * altura / 2
area = ((baseMaior + baseMenor) * altura) / 2;

//Saída de dados = valor da área do trapézio
Console.WriteLine("A área do trapézio é {0}", area);