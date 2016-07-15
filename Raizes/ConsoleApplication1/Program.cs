using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Raiz p = new Raiz();

            Console.WriteLine("Até que numero você deseja?");
            try
            {
                p.limit = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("ERR0!!!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            

            int sqrt = p.getSQRT(p.limit);
            Console.WriteLine(sqrt);

            //float sqrt2 = p.getSQRT2(p.limit);
            //Console.WriteLine(sqrt2);

            Console.ReadKey();
        }
    }
}
