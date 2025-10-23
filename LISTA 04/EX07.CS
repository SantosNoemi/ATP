class EX07
{
    public static void Rodar()
    {
        int numAlunos;
        double mediaAprovados;

        Console.Write("Quantos alunos deseja inserir? ");
        numAlunos = int.Parse(Console.ReadLine());

        //Chama a função de media de alunos aprovados
        mediaAprovados = Media(numAlunos);
        //Verifica se algum foi aprovado ou não
        if (mediaAprovados == 0)
            Console.WriteLine("Nenhum aluno aprovado.");
        else
            Console.WriteLine($"Média dos alunos aprovados: {mediaAprovados:F2}");
    }

    public static double Media(int numAlunos)
    {
        double soma = 0;
        int aprovados = 0;

        //Faz a média de alunos aprovados, de acordo com a quantidade de alunos informado
        for (int i = 1; i <= numAlunos; i++)
        {
            Console.Write($"Insira a nota do aluno {i}: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 6)
            {
                soma += nota; // acumula apenas notas >= 6
                aprovados++;
            }
        }

        if (aprovados == 0) // nenhum aprovado
            return 0;
        else
            return soma / aprovados;
    }
}
