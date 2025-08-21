//Declarando variáveis
double produto, promocao;

//Entrada do valor do produto
Console.WriteLine("Informe o valor do produto: ");
produto = double.Parse(Console.ReadLine());

//Fórmula para calcular promoção
promocao = produto - ( produto * (10.0 / 100));

//Saída de dados
Console.WriteLine($"O valor do produto com desconto aplicado é: {promocao:c}");