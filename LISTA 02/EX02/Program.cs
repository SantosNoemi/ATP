//variáveis
int num1 = 0, num2 = 0, num3 = 0;

//entrada
Console.WriteLine("Digite três números inteiros: ");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());
num3 = int.Parse(Console.ReadLine());

//processamento e saída
if (num1 > num2 && num1 > num3)
    Console.WriteLine("O maior número é: " + num1);
else if (num2 > num1 && num2 > num3)
    Console.WriteLine("O maior número é: " + num2);
else
    Console.WriteLine("O maior número é: " + num3);