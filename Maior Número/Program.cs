using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_Número
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Digite o primeiro numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"O numero {num1} é o maior");
            }
            else if (num2 > num1 && num2 > num3) {
                Console.WriteLine($"O numero {num2} é o maior");
            }
            else if (num3 > num1 && num3 > num1)
            {
                Console.WriteLine($"O numero {num3} é o maior");
            }
        }
    }
}
