//Declarando as variáveis
int a, b, resto, mdc, mmc;

//Lendo os valores de A e B
Console.Write("Digite o valor de A: ");
a = int.Parse(Console.ReadLine());
Console.Write("Digite o valor de B: ");
b = int.Parse(Console.ReadLine());

//Declarando essas variáveis aqui para não perder os valores originais de A e B
int x = a;
int y = b;

//Calculando o MDC usando o Algoritmo de Euclides
while (y != 0)
{
    resto = x % y; //Calcula o resto da divisão
    x = y; //Atribui o valor de Y a X
    y = resto; //Atribui o valor do resto a Y
}
mdc = x; //O MDC é o último valor não nulo de X
mmc = (a * b) / mdc; //Calculando o MMC usando a relação entre MDC e MMC

//Exibindo os resultados
Console.WriteLine($"O MDC de {a} e {b} é: {mdc}");
Console.WriteLine($"O MMC de {a} e {b} é: {mmc}");