using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class Triangulo
    {
        public static void Rodar()
        {
            string resposta = "s";

            //Para para a verificação, digite s
            while (resposta == "s")
            {
                int x, y, z;
                Console.WriteLine("Digite os 3 lados");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                z = int.Parse(Console.ReadLine());

                //chamando o procedimento que verifica se é triangulo
                Verificador(x, y, z); 
                Console.WriteLine("Deseja verificar outro triângulo? (s/n)");
                resposta = Console.ReadLine();
            }
            Console.WriteLine("Programa encerrado.");
        }
        public static void Verificador(int x, int y, int z)
        {
            //Procedimento que verifica se os valores digitados formam um triângulo e que tipo de triângulo é
            if ((x < y + z) && (y < x + z) && (z < x + y)) //é triangulo?
            {
                if ((x == y) && (y == z)) //3 lados iguais
                    Console.WriteLine("Equilátero");
                else if ((x == y) || (x == z) || (y == z)) //2 lados iguais
                    Console.WriteLine("Isoceles");
                else
                    Console.WriteLine("Qualquer"); //3 lados diferentes
            }
            else
                Console.WriteLine("Não é triângulo");
        }
    }
}
