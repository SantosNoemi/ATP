class EX02
{
    public static void Rodar()
    {
        double salario, somaSalario = 0, mediaSalarial;
        int i = 0;

        Console.Write("Digite o salário (ou um valor negativo para encerrar): ");
        salario = double.Parse(Console.ReadLine());

         while (salario >= 0)
        {
            if (salario < 0)
            {
                break;
            }
            somaSalario += salario;
            i++;

           Console.Write("Digite o próximo salário (ou um valor negativo para encerrar): ");
           salario = double.Parse(Console.ReadLine());
 
        }
        
        if (i > 0)
            {
                mediaSalarial = MediaSal(somaSalario, i);
                Console.WriteLine($"A média salarial da população é: R${mediaSalarial:F2}.");
            }
            else 
            {
                Console.WriteLine ("Nenhum salário digitado.");
            }
    }
    public static double MediaSal(double soma, int i)
    {
        return soma/ i;
    }
}