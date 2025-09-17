//Declarando varíaveis
double a, b, r = 0;
char op;

//Entrada de dados
Console.WriteLine("Digite um valor: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Digite outro valor: ");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Operação matemática: ");
op = char.Parse(Console.ReadLine());

//Caso seja o sinal selecionado, faça a operação correspondente
switch (op)
{
    case '+':
        r = a + b;
        break;

    case '-':
        r = a - b;
        break;

    case '*':
        r = a * b;
        break;

    case '/':
        r = a / b;
        break;

    default:
        Console.WriteLine("Inválido");
        break;
}
//Saída de dados
Console.WriteLine("Resultado: " + r);