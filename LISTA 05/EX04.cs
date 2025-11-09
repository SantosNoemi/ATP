class EX04
{
    //Programa para declarar e acionar módulos
    public static void Rodar()
    {
        int[] x = new int[10];
        int[] y = new int[10];
        PreencheVetores(x, y);
        NovoVetor(x, y);
    }
    public static void PreencheVetores(int[] a, int[] b)
    {
        //Preenchendo o vetor A
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"Informe o {i + 1}º elemento do vetor a: ");
            a[i] = int.Parse(Console.ReadLine());
        }
        //Preenchendo o vetor B
        for (int i = 0; i < b.Length; i++)
        {
            Console.WriteLine($"Informe o {i + 1}º elemento do vetor b: ");
            b[i] = int.Parse(Console.ReadLine());
        }
    }
    public static void NovoVetor(int[] a, int[] b)
    {
        int[] nVet = new int[a.Length];

        for (int i = 0; i < nVet.Length; i++)
        {
            //Se for posição par, armazena com valores de B
            if (i % 2 == 0)
                nVet[i] = b[i];
            //Se for posição ímpar, armazena com valores de A
            else
                nVet[i] = a[i];
        }
        Console.WriteLine("\nNovo vetor gerado: ");
        Console.WriteLine(string.Join(", ", nVet));
    }
}