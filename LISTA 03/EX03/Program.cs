//Variaveis
int a, b, s, m;

//Processando dados
for (int x = 1000; x <= 9999; x++)
{
    a = x / 100; //pega os dois primeiros digitos
    b = x % 100; //pega os dois últimos digitos
    s = a + b; //soma os dois
    m = s * s; //multiplica o resultado da soma por si mesma
    if (m == x) //compara o resulta com o valor atual de x
        Console.WriteLine("Resultado: " + m); //saída de dados
}