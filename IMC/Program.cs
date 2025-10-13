using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, imc;

            Console.Write("Digite seu peso: ");
            peso = float.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc <= 16.9)
            {
                Console.WriteLine("Muito abaixo do peso, IMC: " + imc);
            }
            else if (imc >= 17 && imc <= 18.4)
            {
                Console.WriteLine("Abaixo do peso, IMC: " + imc);
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Peso normal, IMC: " + imc);
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Acima do peso, IMC: " + imc);
            }
            else if (imc >= 30 && imc <= 34.4)
            {
                Console.WriteLine("Obesidade grau I, IMC: " + imc);
            }
            else if (imc >= 35 && imc <= 40)
            {
                Console.WriteLine("Obesidade grau II, IMC: " + imc);
            }
            else if (imc > 40)
            {
                Console.WriteLine("Obesidade grau III, IMC: " + imc);
            }
        }
    }
}
