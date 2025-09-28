//Valor de n deve ser positivo
int n = 0;
int intervalo1 = 0, intervalo2 = 0, intervalo3 = 0, intervalo4 = 0;

//Leitura do valor de n
Console.WriteLine("Digite um número (inteiro positivo): ");
n = int.Parse(Console.ReadLine());

//Laço para ler os valores enquanto n for positivo
while (n >= 0)
{
    //Verifica em qual intervalo o valor de n se encaixa e incrementa o contador do respectivo intervalo
    if (n >= 0 && n <= 25)
        intervalo1++;
    else if (n >= 26 && n <= 50)
        intervalo2++;
    else if (n >= 51 && n <= 75)
        intervalo3++;
    else if (n >= 76 && n <= 100)
        intervalo4++;
    else
        Console.WriteLine("Número fora do intervalo");

    //Leitura do próximo valor de n
    Console.WriteLine("Digite números inteiros positivos: ");
    n = int.Parse(Console.ReadLine());
}


//Exibição dos resultados
Console.WriteLine("Quantidade de números lidos entre: ");
Console.WriteLine($"[0-25]: {intervalo1}");
Console.WriteLine($"[26-50]: {intervalo2}");
Console.WriteLine($"[51-75]: {intervalo3}");
Console.WriteLine($"[76-100]: {intervalo4}");