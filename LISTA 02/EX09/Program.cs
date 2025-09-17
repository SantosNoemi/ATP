//Variavel
char dia;

//Entrada de dado
Console.WriteLine("Insira um número entre 1 e 7: ");
dia = char.Parse(Console.ReadLine());

//Processamento e saída de dado
switch (dia)
{
    case '1':
        Console.WriteLine("Domingo");
        break;
    case '2':
        Console.WriteLine("Segunda-feira");
        break;
    case '3':
        Console.WriteLine("Terça-feira");
        break;
    case '4':
        Console.WriteLine("Quarta-feira");
        break;
    case '5':
        Console.WriteLine("Quinta-feira");
        break;
    case '6':
        Console.WriteLine("Sexta-feira");
        break;
    case '7':
        Console.WriteLine("Sábado");
        break;
    default:
        Console.WriteLine("Número inválido.");
        break;
}
