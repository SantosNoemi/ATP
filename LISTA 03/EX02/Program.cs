//variaveis c/ esses valores iniciais para garantir que qualquer altura digitada será maior ou menor
double menor = 999, maior = 1, altura;

//Laço para ler as alturas de 15 pessoas
for (int i = 0; i < 15; i++)
{
    Console.WriteLine($"Digite a altura da {i + 1}ª pessoa: ");
    altura = double.Parse(Console.ReadLine());

    //Verifica se a altura lida é menor que a menor altura já registrada ou maior que a maior altura já registrada
    //Ifs independentes, pois ambas as verificações devem ser feitas para cada altura lida
    if (altura < menor)
    {
        menor = altura;
    }
    if (altura > maior)
    {
        maior = altura;
    }
}
//Saída dos resultados da menor e maior altura
Console.WriteLine($"A menor altura é: {menor:F2} e a maior altura é: {maior:F2}");