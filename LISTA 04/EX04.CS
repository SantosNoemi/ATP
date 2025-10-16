class EX04
{
    public static void Rodar()
    {
        int x = 0, y = 0, r = 0;
        Console.WriteLine("Insira o valor de X: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o valor de y: ");
        y = int.Parse(Console.ReadLine());
        r = MDC(x, y);
        Console.WriteLine($"O MDC de {x} e {y} é {r}.");
    }
    static int MDC(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while(b != 0)
        {
            int resto = a % b;
            a = b;
            b = resto;
        }
        return a;
    }
}