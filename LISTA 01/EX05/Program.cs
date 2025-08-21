//Variáveis
double r, c, area, volume;

//Entrada de dados
Console.WriteLine("Informe o valor do raio: ");
r = double.Parse(Console.ReadLine());

//Formúlas
c = 2 * Math.PI * r;
area = Math.PI * Math.Pow(r, 2);
volume = 4 / 3 * Math.PI * Math.Pow(r, 3);

//Saída de dados
Console.WriteLine($"O comprimento de uma esfera é: {c:F2}");
Console.WriteLine($"A área de uma esfera é: {area:F2}");
Console.WriteLine($"O volume de uma esfera é: {volume:F2}");
