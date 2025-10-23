class EX06
{
    public static void Rodar()
    {
        //declarando as variaveis
        double salario, indice;
        Console.WriteLine("Insira o salário: ");
        salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira o índice de reajuste: ");
        indice = double.Parse(Console.ReadLine());
        //chamando o procedimento que fará o calculo
        Reajuste(salario, indice);
    }
    public static void Reajuste( double s, double ind)
    {
        // procedimento que multiplica o valor do salario pela porcentagem e divide por 100
        double valorAcres = s * ind / 100;
        //e soma o resultado com o salario já existente
        double novoSalario = s + valorAcres;
        //Apresentando o novo salário
        Console.WriteLine("O valor atualizado do salário é: R$ " + novoSalario);
    }
}