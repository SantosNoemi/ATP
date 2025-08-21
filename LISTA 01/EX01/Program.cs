//Declarando variavéis
double nota1, nota2, mediaPonderada; 

//Entrada de dados
Console.WriteLine("Insira a primeira nota(seu respectivo peso é 2): ");
nota1 = double.Parse (Console.ReadLine());
Console.WriteLine("Insira a segunda nota(seu respectivo peso é 3): ");
nota2 = double.Parse (Console.ReadLine());

//Processamento
//Multiplicação das notas pelos seus respectivos pesos e divisão pela soma dos pesos
mediaPonderada = (nota1 * 2 + nota2 * 3) / 5; 

//Saída de dados
Console.WriteLine("A média ponderada das notas é {mediaPonderada}", mediaPonderada);