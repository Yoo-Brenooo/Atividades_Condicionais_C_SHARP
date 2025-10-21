    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Calculadora
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string operador;
                int x, y;
                int resultado = 0;

                Console.Write("Digite o primeiro numero: ");
                x = int.Parse(Console.ReadLine());

                Console.Write("Digite o primeiro numero: ");
                y = int.Parse(Console.ReadLine());

                Console.Write("Digite o operador (+, _, *, /): ");
                operador = Console.ReadLine();

                switch (operador) {
                    case "+":
                        resultado = x + y;
                        break;
                    case "-":
                        resultado = x - y;
                        break;
                    case "*":
                        resultado = x * y;
                        break;
                    case "/":
                        resultado = x / y;
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }

                Console.WriteLine($"O resultado é: {resultado}");
            }
        }
    }
