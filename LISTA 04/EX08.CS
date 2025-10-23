class EX08
{
    public static void Rodar()
    {
        Console.Write("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        if (EhPrimo(n))
            Console.WriteLine($"{n} é primo.");
        else
            Console.WriteLine($"{n} não é primo.");
    }
    
    // Função que verifica se um número é primo
    public static bool EhPrimo(int numero)
    {
        if (numero <= 1) // 0 e 1 não são primos
            return false;

        // Verifica divisores de 2 até a raiz quadrada do número
        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
                return false; // achou divisor, não é primo
        }

        return true; // não encontrou divisor, é primo
    }
}
