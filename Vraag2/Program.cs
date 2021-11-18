using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] postnummer =new int[] { 9300, 2000, 1000, 9200, 9000, 8500, 9700, 2300 };
            string[] stadNaam =new string[] { "Aalst", "Antwerpen", "Brussel", "Dendermonde", "Gent", "Kortrijk", "Oudenaarde", "Turnhout" };
            int nummerPost = int.Parse(Console.ReadLine());
            for (int i = 0; i < postnummer.Length; i++)
            {
                if (nummerPost == postnummer[i])
                {
                    Console.WriteLine(stadNaam[i]);

                }
              
            }
        }
    }
}
