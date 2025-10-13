using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Digite sua idade nadador: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Vc é da classe Infatil A");
            }
            else if (idade >= 8 && idade <= 11)
            {
                Console.WriteLine("Vc é da classe Infantil B");
            }
            else if (idade >= 12 && idade <= 13)
            {
                Console.WriteLine("Vc é da classe Juvenil A");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Vc é da classe Juvenil B");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("Vc é da classe Adultos");
            }
        }
    }
}

