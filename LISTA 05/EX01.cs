class EX01
{
    public static void Rodar()
    {
        Random r = new Random();
        int[] vetor = new int[15];
        for (int i = 0; i < vetor.Length; i++)
        {
            //preenchendo o vetor com números inteiros aleatórios entre 1 e 50
            vetor[i] = r.Next(1, 50);
        }
        //Chamando a função que pega as posições pares
        int[] resultado = PosicaoPar(vetor); 

        Console.WriteLine("Os números das posições pares do vetor são: ");
        Console.WriteLine(string.Join(", ", resultado));
    }

     // Função que retorna os números das posições pares do vetor
    public static int[] PosicaoPar(int[] vetor)
    {
        int quantidade = (vetor.Length + 1) / 2;
        int[] result = new int[quantidade];
        int x = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (i % 2 == 0) //se a posição do vetor for par
            {
                result[x] = vetor[i]; //armazena o valor da posição dentro do outro vetor
                x++;
            }
        }
        return result;
    }
}