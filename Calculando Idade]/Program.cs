using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_Idade_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1° Passo - Declarar as Variaveis
            int anoNascimento, anoAtual, idade;

            //2° Passo - Entrada de Dados
            Console.WriteLine("Adivinhador de Idade");

            Console.Write("Digite o ano atual: ");
            anoAtual = int.Parse(Console.ReadLine());

            Console.Write("Digite seu ano de nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());

            //3° Passo - Processamento
            idade = anoAtual - anoNascimento;

            //4° Passo - Saída
            Console.Write("A sua idade: " + idade);

            Console.ReadKey();
        }
    }
}
