class EX04
{
    public static void Rodar()
    {
        //Declarando as variáveis para encontrar o MDC delas
        int x = 0, y = 0, r = 0;
        Console.WriteLine("Insira o valor de X: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o valor de y: ");
        y = int.Parse(Console.ReadLine());
        r = MDC(x, y); //Chamando a função que faz esse calculo
        Console.WriteLine($"O MDC de {x} e {y} é {r}.");
    }
    static int MDC(int a, int b)
    {
        //Mantendo as variaveis sempre positivas
        a = Math.Abs(a);
        b = Math.Abs(b);
        //Enquanto b for diferente de 0, para não dar erro de divisão
        while(b != 0)
        {
            //iremos fazer a troca de valores
            int resto = a % b;
            a = b;
            b = resto;
        }
        return a; //O a irá carregar o resultado do MDC
    }
}