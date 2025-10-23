class EX02
{
    public static void Rodar()
    {
        double salario, somaSalario = 0, mediaSalarial;
        int i = 0;

        Console.Write("Digite o salário (ou um valor negativo para encerrar): ");
        salario = double.Parse(Console.ReadLine());
        //enquanto o valor de salario for positivo será somado com o valor já existente
         while (salario >= 0)
        {
            if (salario < 0)
            {
                break;
            }
            somaSalario += salario;
            i++; //conta quantos salarios estão sendo adicionados

           Console.Write("Digite o próximo salário (ou um valor negativo para encerrar): ");
           salario = double.Parse(Console.ReadLine());
 
        }
        //Se tiver alguma quantidade de salario depositada em i, ele chamara a função que fará a média salarial
        if (i > 0)
        {
                //chamando a função colocando os paramentros da soma dos salarios e a quantidade digitada
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
        //Função que calcula e retorna a média salarial da população
        return soma/ i;
    }
}