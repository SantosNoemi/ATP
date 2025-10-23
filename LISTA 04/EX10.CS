class EX10
{
    public static void Rodar()
    {
        Console.Write("Digite a média final do aluno: ");
        double media = double.Parse(Console.ReadLine());

        char conceito = ObterConceito(media);

        if (conceito != 'X') // verifica se a média é válida
            Console.WriteLine($"O conceito do aluno é: {conceito}");
    }
    
    // Função que retorna o conceito do aluno com base na média
    public static char ObterConceito(double media)
    {
        if (media < 0 || media > 10)
        {
            Console.WriteLine("Média inválida! Deve estar entre 0 e 10.");
            return 'X'; // valor indicativo de erro
        }
        else if (media <= 4.9)
            return 'D';
        else if (media <= 6.9)
            return 'C';
        else if (media <= 8.9)
            return 'B';
        else
            return 'A';
    }
}
