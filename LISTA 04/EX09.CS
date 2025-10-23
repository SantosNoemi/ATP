class EX09
{
    public static void Rodar()
    {
        Console.Write("Digite a hora de início: ");
        int inicioHora = int.Parse(Console.ReadLine());

        Console.Write("Digite os minutos de início: ");
        int inicioMin = int.Parse(Console.ReadLine());

        Console.Write("Digite a hora de término: ");
        int fimHora = int.Parse(Console.ReadLine());

        Console.Write("Digite os minutos de término: ");
        int fimMin = int.Parse(Console.ReadLine());

        int durHora = 0, durMin = 0;
        //Chamando o procedimento
        DuracaoJogo(inicioHora, inicioMin, fimHora, fimMin, ref durHora, ref durMin);

        Console.WriteLine($"Duração do jogo: {durHora} hora(s) e {durMin} minuto(s).");
    }
    // Procedimento que calcula a duração do jogo
    public static void DuracaoJogo(int inicioHora, int inicioMin, int fimHora, int fimMin, 
                                    ref int durHora, ref int durMin)
    {
        // Converte tudo para minutos
        int inicioTotalMin = inicioHora * 60 + inicioMin;
        int fimTotalMin = fimHora * 60 + fimMin;
        int duracaoMin;

        if (fimTotalMin >= inicioTotalMin)
        {
            duracaoMin = fimTotalMin - inicioTotalMin;
        }
        else
        {
            // jogo passou da meia-noite
            duracaoMin = (24 * 60 - inicioTotalMin) + fimTotalMin;
        }

        // Converte de volta para horas e minutos
        durHora = duracaoMin / 60;
        durMin = duracaoMin % 60;
    }
}
