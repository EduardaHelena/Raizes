using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raizes
{
    class Raiz
    {
        public int limit = 100;
        
        public int getSQRT(int limit)
        {
            int count = 0;
            int currentImpar = 1;
            while (limit - currentImpar >= 0)
            {
                count++;
                limit -= currentImpar;
                currentImpar += 2;
            }
            return count;
        }

        //public float getSQRT2(int limit)
        //{
        //    int soma = 0;
        //    int currentImpar = 1;
        //    int currentNumber = 0;
        //    while (soma + currentImpar <= limit)
        //    {
        //        soma += currentImpar;
        //        currentImpar += 2;
        //        currentNumber++;

        //        Console.WriteLine("Soma: " + soma);
        //    }

            
        //    return currentNumber;
        //}
    }
}

// 1, 3, 5, 7, 9