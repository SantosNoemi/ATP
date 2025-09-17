//Variaveis
char sexo;
double altura, pesoideal;

//Entrada de dados
Console.WriteLine("Insira o seu sexo (f ou m) e altura respectivamente: ");
sexo = char.Parse(Console.ReadLine());
altura = double.Parse(Console.ReadLine());

//Processamento e saída de dados
switch (sexo)
{
    case 'f':
        pesoideal = (62.1 * altura) - 44.7;
        Console.WriteLine($"O seu peso ideal é: {pesoideal:F2}kg.");
        break;
    case 'm':
        pesoideal = (72.7 * altura) - 58;
        Console.WriteLine($"O seu peso ideal é: {pesoideal:F2}kg.");
        break;
    default:
        Console.WriteLine("Resposta inválida. Por favor digite f ou m para informar o seu sexo.");
        break;
}