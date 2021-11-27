using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o tamanho da base menor: ");
            double baseMenor = double.Parse(Console.ReadLine());

            Console.Write("Informe o tamanho da base Maior: ");
            double baseMaior = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura: ");
            double altura = double.Parse(Console.ReadLine());

            double area = (baseMaior + baseMenor) * altura / 2;

            Console.Write("A Área do Trapézio é de: "+ area);

            Console.ReadKey();
        }
    }
}
