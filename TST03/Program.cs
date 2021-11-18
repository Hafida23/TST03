using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TST03
{
    class Program
    {
        static void Main(string[] args)
        {
            double betaal;
            Console.Write("de fatuur bedrag is : ");
            double factuur=double.Parse(Console.ReadLine());

            if(factuur > 5000)
            {
                betaal = (1 - 0.05) * factuur;
                Console.WriteLine("betaal is : "+betaal);
            }
            else
            {
                betaal = factuur;
                Console.WriteLine("betaal is : " + betaal);
            }
            

            
        }
    }
}
