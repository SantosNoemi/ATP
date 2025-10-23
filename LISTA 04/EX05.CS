class EX05
{
    public static void Rodar()
    {
        //declarando a variavel
        int num = 0;
        Console.WriteLine("Insira um número inteiro: ");
        num = int.Parse(Console.ReadLine());
        //Chamando uma função que verifica se é um numero positivo ou negativo
        if (Positivo(num)) //se for, cai aqui
        {
            Console.WriteLine($"{num} é positivo.");
        }
        else //se não for, cai direto para cá e finaliza.
        {
            Console.WriteLine($"{num} é negativo.");
        }
    }
    public static bool Positivo(int n)
    {
        //Função que verifica se é positivo ou negativo
        return n >= 0;
    }
}