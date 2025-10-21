using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Projeto_Soma{
    internal class Program{
        static void Main(string[] args){

            //1° Passo - Declarar as variaveis

            float num1, num2, resultado;
            string nome;

            Console.WriteLine("Projeto Soma");

            Console.WriteLine("Digite seu Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o Primeiro Valor: ");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo  Valor: ");
            num2 = float.Parse(Console.ReadLine());

            //2° Passo - Processamento           

            resultado = num1 + num2;

            //3° Passo - Saída

            Console.WriteLine("Olá" + nome + "e o resultado é:" + resultado);

            Console.WriteLine("Clique a tecla <ENTER> para continuar.");
        }
    }
}
        