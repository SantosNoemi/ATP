//Variável
int num;

//Entrada de dados
Console.WriteLine("Digite um número inteiro: ");
num = int.Parse(Console.ReadLine());

//Processamento e saída de dados
if (num > 0)
    Console.WriteLine("O número é positivo.");

else if (num < 0)
    Console.WriteLine("O número é negativo.");
else
    Console.WriteLine("O número é zero.");