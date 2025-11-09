class EX02()
{
    public static void Rodar()
    {
        double[] notas = new double[10];
        PreencherNotas(notas);
        Somatoria(notas);
    }

    public static void Somatoria(double[] notas)
    {
        double soma = 0;
        int acimaMedia = 0;

        //somanda todas as notas para tirar a média
        for (int i = 0; i < notas.Length; i++)
            soma += notas[i];

        //Média geral da turma
        double media = soma / notas.Length;
        for (int i = 0; i < notas.Length; i++)
        {
            //Se a nota for acima da média, contabiliza na variavel
            if (notas[i] > media)
                acimaMedia++;
        }

        Console.WriteLine("\nMédia geral da turma: " + media.ToString("F2"));
        Console.WriteLine("Total de alunos acima da média: " + acimaMedia);
    }
    public static void PreencherNotas(double[] notas)
    {
        //Preenchendo o vetor com as notas dos alunos
        for (int n = 0; n < notas.Length; n++)
        {
            Console.WriteLine($"Insira a nota do {n + 1}º aluno: ");
            notas[n] = double.Parse(Console.ReadLine());
        }
    }
}