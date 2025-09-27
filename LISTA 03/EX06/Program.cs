//Variaveis
int a, n, soma = 0;

//Pede ao usuario para indicar o valor de A e N
Console.WriteLine("Informe o valor de A: ");
a = int.Parse (Console.ReadLine());
Console.WriteLine("Informe o valor de N: ");
n = int.Parse (Console.ReadLine());

//Condicional para caso o A fornecido seja negativo
while (n <= 0)
{
    Console.WriteLine("Número inválido. Informe um novo valor para N: ");
    n = int.Parse (Console.ReadLine());
}
//Laço de repetição para atualizar o valor de soma e somar com o valor de A
//Dessa forma, os próximos números após A estão na sequencia numerica
//Ex: soma = 0, A = 3, i = 1 | soma = 0 + 3 + 1 | soma = 4
for (int i = 0; i < n; i++)
{
    soma = soma + a + i;
} 
//Saída de dados
Console.WriteLine ("A soma dos {0} termos à partir de A foram: {1}", n, soma);