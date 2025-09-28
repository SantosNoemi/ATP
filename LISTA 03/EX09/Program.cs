//Declarando variáveis
int voto, candidato1 = 0, candidato2 = 0, candidato3 = 0, candidato4 = 0;
int nulo = 0, branco = 0, totalVotos = 0;

//Lendo o primeiro voto
Console.Write("Insira o seu voto (1, 2, 3, 4, 5 para nulo e 6 para branco): ");
voto = int.Parse(Console.ReadLine());

//While para continuar recebendo votos até que o usuário insira 0
while (voto != 0)
{
    //Contabilizando os votos
    switch (voto)
    {
        case 1:
            candidato1++;
            break;
        case 2:
            candidato2++;
            break;
        case 3:
            candidato3++;
            break;
        case 4:
            candidato4++;
            break;
        case 5:
            nulo++;
            break;
        case 6:
            branco++;
            break;
        default:
            Console.WriteLine("Voto inválido!");
            break;
    }
    //Incrementando o total de votos e lendo o próximo voto
    totalVotos++; //Aqui todo voto diferente de 0 é contado, inclusive os inválidos
    Console.Write("Insira o seu voto (1, 2, 3, 4, 5 para nulo e 6 para branco): ");
    voto = int.Parse(Console.ReadLine());
}

//Exibindo o resultado da votação
Console.WriteLine("-------------------------------------");
Console.WriteLine("Obrigado por votar!");
Console.WriteLine("-------------------------------------");
Console.WriteLine($"Total de votos: {totalVotos}");
Console.WriteLine($"Candidato 1: {candidato1} votos");
Console.WriteLine($"Candidato 2: {candidato2} votos");
Console.WriteLine($"Candidato 3: {candidato3} votos");
Console.WriteLine($"Candidato 4: {candidato4} votos");
Console.WriteLine($"Votos nulos: {nulo}");
Console.WriteLine($"Votos em branco: {branco}");