class EX05
{
    public static void Rodar()
    {
        int[] numerosSorteados = Sorteio(); //criando um novo vetor para o procedimento
        bool acertou = false;

        Console.WriteLine("---------- SORTEIO DE NÚMEROS ENTRE 10 E 30 ----------");
        Console.WriteLine();

        do
        {
            Console.WriteLine("Informe um número: ");
            int tentativa = int.Parse(Console.ReadLine());
            //Verificando se o número digitado é igual ao número da posição atual do vetor
            for (int i = 0; i < 5; i++)
            {
                if (tentativa == numerosSorteados[i])
                {
                    acertou = true; //caso seja, a pessoa acertou
                }
            }
            if (!acertou) //caso não, exibe a mensagem
            {
                Console.WriteLine("Número errado! Tente novamente: ");
            }

        } while (acertou == false); //so sai do loop quando a pessoa acertar
        Console.WriteLine("Parabéns! Você acertou");
    }
    public static int[] Sorteio()
    {
        //Criando o objeto r
        Random r = new Random();
        int[] numeros = new int[5];
        //Guardando os valores sorteados dentro de cada posição do vetor
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = r.Next(10, 30);
        }
        return numeros;
    }
}