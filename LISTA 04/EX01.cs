class EX01
{
    public static void Rodar()
    {
        int x, y, resposta;
        Console.WriteLine ("Insira o valor da base x: ");
        x = int.Parse (Console.ReadLine());
        Console.WriteLine ("Insira o valor do expoente y: ");
        y = int.Parse (Console.ReadLine());
        resposta = Potencia(x,y);
        Console.WriteLine ("Resposta: " + resposta);            
    }
    public static int Potencia(int a, int n)
    {
        int m = 1;
        for (int x = 0; x < n; x++)
        {
            m = m * a;
        }
        return m;
    }
}