using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe sua idade em anos: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idade em meses: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idade em dias: ");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = (n * 12) + n1;

            Console.WriteLine("Idade em meses: " + resultado);

            int resultado2 = (n * 365) + (n1 * 30) + n2;

            Console.WriteLine("Idade em dias: " + resultado2);

            Console.ReadKey();

        }
    }
}
