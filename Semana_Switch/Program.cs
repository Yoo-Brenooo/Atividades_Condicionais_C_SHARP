using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int diaSemana;

            Console.Write("Digite um numero da semana de 1 a 7: ");
            diaSemana = int.Parse(Console.ReadLine());

            switch (diaSemana) {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda");
                    break;
                case 3:
                    Console.WriteLine("Terça");
                    break;
                case 4:
                    Console.WriteLine("Quarta");
                    break;
                case 5:
                    Console.WriteLine("Quinta");
                    break;
                case 6:
                    Console.WriteLine("Sexta");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        }
    }
}