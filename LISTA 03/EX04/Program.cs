//Variáveis
int a = 0, b = 1, c, n;

//Entrada
Console.WriteLine("Digite o número de termos da sequência de Fibonacci que deseja exibir:");
n = int.Parse(Console.ReadLine());

//Processamento e Saída
if (n <= 0)
{
    Console.WriteLine("Digite um número maior que zero.");
}
else
{
    Console.WriteLine("Sequencia de Fibonacci:");
    for (int i = 1; i <= n; i++) //Loop para calcular e exibir os termos
    {
        Console.Write(a + " "); //Exibe o valor atual de 'a'
        c = a + b; //Calcula o próximo termo   
        a = b;
        b = c;
    }
}