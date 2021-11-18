using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag3
{
    class Program
    {
        static void Main(string[] args)
        {
            int rijpost = 0;
            int kolompost = 0;
            char stop = ' ';
            int[,] ei = { { 0,2},{ 2,2} };
            char[,] spelletje = new char[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    spelletje[i, j] = '_';
                }
            }

            do
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write(spelletje[j, i] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Vind het passei, geef een rij (0-9) :");
                int rij = int.Parse(Console.ReadLine());
                Console.WriteLine("geef een kolom(0-9) :");
                int kolom = int.Parse(Console.ReadLine());
                spelletje[rijpost, kolompost] = '_';
                Console.Clear();
                if (rij < 9 && rij > 0)
                {
                    rijpost = rij;
                    if (kolom < 9 && kolom > 0)
                        kolompost = kolom;
                    spelletje[rijpost, kolompost] = 'X';
                }
                else 
                {
                    if (spelletje[kolom,rij] < ei[2,2])
                        Console.WriteLine("Het ei ligt meer naar het zuiden");
                    else
                        Console.WriteLine("Het ei ligt meer naar het noorden");
                    if (spelletje[kolom, rij] < ei[2, 2])
                        Console.WriteLine("Het ei ligt meer naar het oosten");
                    else
                        Console.WriteLine("Het ei ligt meer naar het westen");

                }

                //Console.WriteLine("Je hebt het ei gevonden ! Druk <enter> om opniew te spelen type e om af te sluiten");
                //stop = Char.Parse(Console.ReadLine());
            } while (stop != 'e');
        }
    }
}
