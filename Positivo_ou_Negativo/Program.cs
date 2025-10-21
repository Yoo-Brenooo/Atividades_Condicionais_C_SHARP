using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positivo_ou_Negativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite um numero: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0) {
                Console.WriteLine("Seu numero é positivo");
        }
            else if (num < 0) {
                Console.WriteLine("Seu numero é negativo");
            }
        }
    }
}
