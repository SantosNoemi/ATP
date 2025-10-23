class EX01
{
    public static void Rodar()
    {
        //declarando as variáveis de base e expoente
        int x, y, resposta;
        Console.WriteLine ("Insira o valor da base x: ");
        x = int.Parse (Console.ReadLine());
        Console.WriteLine ("Insira o valor do expoente y: ");
        y = int.Parse(Console.ReadLine());
        //chamando uma função que faz o calculo de uma potência sem usa Math.Pow
        resposta = Potencia(x,y); 
        Console.WriteLine ("Resposta: " + resposta);            
    }
    public static int Potencia(int a, int n) //a = x, e n = y
    {
        //função que multiplica a base n vezes, de acordo com o valor do expoente
        int m = 1; //só para a base se multiplicar por ela mesma
        for (int x = 0; x < n; x++)
        {
            m = m * a;
        }
        return m; //retorna o valor do calculo
    }
}