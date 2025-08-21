//Variáveis
double salarioMinimo, salariofuncionario, qntdsalarios;

//Entrada de dados
Console.WriteLine("Qual o salário minímo atual: ");
salarioMinimo = double.Parse(Console.ReadLine());
Console.WriteLine("Qual o salário do funcionário: ");
salariofuncionario = double.Parse(Console.ReadLine());

//Calculo da quantidade de salários
qntdsalarios = salariofuncionario / salarioMinimo;

//Saída de dados
Console.WriteLine($"A quantidade de salários minímos equivalente ao salário deste funcionário é: {qntdsalarios:0}.");