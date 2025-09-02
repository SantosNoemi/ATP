int ano;
Console.WriteLine("Digite um ano para testar se ele é Bissexto: ");
ano = int.Parse(Console.ReadLine());

if( ano % 4 == 0 && ano % 100 != 0)
    Console.WriteLine("O ano " + ano + " é Bissexto.");
else if (ano % 400 == 0 && ano % 100 == 0)
    Console.WriteLine("O ano " + ano + " é Bissexto.");
else
    Console.WriteLine("O ano " + ano + " não é Bissexto.");