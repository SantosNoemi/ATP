using System.Globalization;

class EX03()
{
    public static void Rodar()
    {
        //Definindo o tamanho do vetor
        Console.WriteLine("Defina o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];

        //Preenchendo as posições do vetor
        for (int i = 0; i < v.Length; i++)
        {
            Console.WriteLine($"informe o {i + 1}º número: ");
            v[i] = int.Parse(Console.ReadLine());
        }
        //Chamando a função que informa o menor elemento
        int posicaoMenor = Menor(v);
        Console.WriteLine($"\nO menor elemento está na posição: {posicaoMenor}");
        Console.WriteLine($"Valor do menor elemento: {v[posicaoMenor]}");
    }
    
    public static int Menor(int[] vet)
    {
        //Declarando as variaveis já assumindo que o menor é o primeiro
        int posicao = 0;
        int menor = vet[0];

        //For para localizar o menor e guardar na posição
        for (int i = 0; i < vet.Length; i++)
        {
            if (vet[i] < menor)
            {
                menor = vet[i];
                posicao = i;
            }
        }
        return posicao;
    }
}
