//declara PI com valor inicial 0, pois o valor sera atualizado
double pi = 0; 

//Usuário informa a quantidade de termos
Console.WriteLine ("Informe quantos termos serão calculados na serie de Leibniz: ");
int n = int.Parse (Console.ReadLine());

//laço de repetição para realizar o cálculo com a quantidade de termos informada
for (int i = 0; i < n; i++)
{
    //Math.Pow (-1... é para sempre alternar entre + ou -
    //sempre que i for par, o sinal é +
    //sempre que i for impar, o sinal é -
    double termo = Math.Pow (-1, i) / (2 * i +1); 
    //Atualiza o valor de PI e deposita na variável
    pi = pi + termo;
}
//depois multiplica o resultado por 4 para se apróximar do valor de PI
pi = pi * 4;

//saída de dados
Console.WriteLine ($"O valor aproximado de PI com {n} termos é: {pi}");