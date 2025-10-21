using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Cores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cor_ingles;

            Console.Write("Digite uma cor em ingles (vermelho, verde, azul ou roxo): ");
            cor_ingles = Console.ReadLine(). ToUpper();

            switch (cor_ingles) {

                case "RED":
                    Console.WriteLine("Vermelho");
                    break;
                case "GREEN":
                    Console.WriteLine("Verde");
                    break;
                case "BLUE":
                    Console.WriteLine("Azul");
                    break;
                case "PURPLE":
                    Console.WriteLine("Roxo");
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        }
    }
}
