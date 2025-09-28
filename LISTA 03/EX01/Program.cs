//Variavel
int soma = 0;

//Processamento
//Se for múltiplo de 3 e ímpar, será somado
for (int x = 1; x <= 500; x++)
{
    if (x % 2 != 0 && x % 3 == 0)
    {
        soma = soma + x;
    }
}
//Saida de dados
Console.WriteLine("A soma dos números ímpares e múltiplos de 3 é: " + soma);