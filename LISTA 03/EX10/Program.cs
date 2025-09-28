//Declaração das variáveis
double salario, somaSalario = 0, mediaSalario, mediaFilhos, perc1500;
int filhos, somaFilhos = 0, i = 0, cont1500 = 0;

//Lendo o primeiro salário
Console.Write("Informe os dados do habitante: ");
Console.Write("Digite o salário (ou um valor negativo para encerrar): ");
salario = double.Parse(Console.ReadLine());

//Loop para ler os dados dos habitantes até que um salário negativo seja inserido
while (salario >= 0)
{
    //Lendo o número de filhos
    Console.Write("Quantidade de filhos: ");
    filhos = int.Parse(Console.ReadLine());

    // Acumulando os valores para cálculo das médias e percentual
    somaSalario += salario;
    somaFilhos += filhos;
    i++;

    // Contando quantos têm salário até 1500
    if (salario <= 1500)
    {
        cont1500++;
    }

    // Lendo o próximo salário
    Console.Write("Digite o salário (ou um valor negativo para encerrar): ");
    salario = double.Parse(Console.ReadLine());
}

// Calculando e exibindo os resultados
if (i > 0)
{
    mediaSalario = somaSalario / i;
    mediaFilhos = (double)somaFilhos / i;
    perc1500 = ((double)cont1500 / i) * 100;

    Console.WriteLine($"Média salarial da população: R$ {mediaSalario:F2}");
    Console.WriteLine($"Média do número de filhos: {mediaFilhos:F2}");
    Console.WriteLine($"Percentual de pessoas com salário até R$ 1500,00: {perc1500:F2}%");
}
else
{
    Console.WriteLine("Nenhum dado informado.");
}
