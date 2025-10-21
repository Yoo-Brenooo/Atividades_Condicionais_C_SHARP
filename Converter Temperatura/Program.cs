using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1° Passo - Declarar as Variaveis
            float tempF, tempC;

            //2° Passo - Entrada de Valores
                       Console.WriteLine("Conversor de Temperatura");
            Console.WriteLine("Digite a temperatura em C°: ");
            tempC = float.Parse(Console.ReadLine());

            //3° Passo - Convertendo Celsius para Fahrenheint
            tempF = (9 * tempC + 160) / 5;

            //4° Passo - Saída de Dados
            Console.WriteLine("Temperatura em Fahrenheit: " + tempF);

            Console.ReadKey();
        }
    }
}
