using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            Console.WriteLine("Digite um número: ");
            double num = double.Parse(Console.ReadLine());

            while (cont <= 100)
            {
                double mult = num * cont;
                Console.WriteLine(mult);
                cont++;
            }

            Console.ReadKey();
        }
    }
}
