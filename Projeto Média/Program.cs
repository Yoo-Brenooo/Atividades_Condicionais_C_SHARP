using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Média
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1° Passo - Declarar as variaveis

            string nomeAluno;
            float nota1, nota2, nota3, media;

            //2° Passo - Entrada de Dados

            Console.WriteLine("Seja Bem-Vindo ao Boletim Virtual");

            Console.Write("Digite o nome do aluno: ");
            nomeAluno = Console.ReadLine();

            Console.Write("Digite sua primeira nota:");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Digite sua segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Digite sua terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            //3° Passo - Calculando a Média

            media = (nota1 + nota2 + nota3) / 3;

            //4° Passo - Condicionando + Saída de Dados 

            if (media >= 5.00)
            {
                Console.WriteLine("Parabéns " + nomeAluno + ", Voce passou com a média de " + media + "!!");
            }
            else if (media >=3 && media <= 4) {
                Console.WriteLine(nomeAluno + ", Infezlimente você ficou de recuperação com sua média de " + media + "!!");
            }
            else
            {
                Console.WriteLine(nomeAluno + ", Infezlimente você não passou com sua média de " + media + "!!");
            }
        }

    }
}
