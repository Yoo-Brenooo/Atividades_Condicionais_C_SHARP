using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario_Professor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nivel, qAulas;
            int salario = 0;

            Console.Write("Digite o nivel do professor: ");
            nivel = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de aulas dada na semana: ");
            qAulas = int.Parse(Console.ReadLine());

            if (nivel == 1)
            {
                salario = 12 * qAulas;
            }
            else if (nivel == 2)
            {
                salario = 17 * qAulas;
            }
            else if (nivel == 3)
            {
                salario = 25 * qAulas;
            }

            Console.Write("O salario é de: " + salario);
        }
    }
}

