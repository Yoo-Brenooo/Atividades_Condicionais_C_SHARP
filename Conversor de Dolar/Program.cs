using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Dolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1° Passo - Declarar as Variaveis
            float real, dolar, cotacaoDolar;

            //2° Passo - Entrada de Dados

            Console.WriteLine("Bem-Vindo ao Conversor de Dolar");

            Console.Write("Digite a Cotação do dolar de hoje: ");
            cotacaoDolar = float.Parse(Console.ReadLine());

            Console.Write("Digite sua quantia de dinheiro em Dolar: ");
            dolar = float.Parse(Console.ReadLine());

            //3° Passo - Processamento
            real = dolar * cotacaoDolar;

            //4° Passo - Saída
            Console.WriteLine("O Valor convertido para reais é: " + real);

            Console.ReadKey();
            



           }
    }
}
