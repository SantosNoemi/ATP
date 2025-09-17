//Variáveis
double htrabalhadas, salariohora, salariobruto, salarioliquido;

//Entrada de dados
Console.WriteLine("Informe as horas trabalhadas: ");
htrabalhadas = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor recebido por horas trabalhadas: ");
salariohora = int.Parse(Console.ReadLine());

//Processamento de dados
salariobruto = htrabalhadas * salariohora;
if (salariobruto <= 900)
{
    salarioliquido = salariobruto * 0.08;
    salarioliquido = salariobruto - salarioliquido;
}
else if (salariobruto >= 900.01 && salariobruto <= 1500)
{
    salarioliquido = salariobruto * 0.9;
    salarioliquido = salariobruto - salarioliquido;
}
else if (salariobruto >= 1500.01 && salariobruto <= 2500)
{
    salarioliquido = salariobruto * 0.1;
    salarioliquido = salariobruto - salarioliquido;
}
else
{
    salarioliquido = salariobruto * 0.11;
    salarioliquido = salariobruto - salarioliquido;
}
//saída de dados
Console.WriteLine("O salário líquido do funcionário será: " + salarioliquido);
