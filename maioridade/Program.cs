using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maioridade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade;

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Vc é maior de idade!");
            }
            else
            {
                Console.WriteLine("Vc n é maior de idade!");
            }
        }
    }
}
