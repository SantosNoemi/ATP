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
            int x, y, z;
            Console.WriteLine("Digite os 3 lados");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            if ((x < y + z) && (y < x + z) && (z < x + y)) //é triangulo?
            {
                if ((x == y) && (y == z))
                    Console.WriteLine("Equilátero");
                else if ((x == y) || (x == z) || (y == z))
                    Console.WriteLine("Isoceles");
                else 
                    Console.WriteLine("Qualquer");
            }
            else
                Console.WriteLine("Não é triângulo");
        }
    }
}
