using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Allahindluse arvestamise programm, kirjuta enda toote hind.");
            double summa = int.Parse(Console.ReadLine());
            double tavak= 0;
            double pysik= 0;
            //tavaklient

            if (summa >= 50 && summa < 250)
            {
                 tavak = (summa * 0.9);
                //Console.WriteLine("Tavakliendi hind on:" + tavak);
            }
           
            if (summa < 350 && summa > 250)
            {
                 tavak = (summa * 0.8);
            }

            

            if (summa > 350)
            {
                 tavak = (summa * 0.7);
            }

            //pysiklient

            if (summa > 50 && summa < 250)
            {
                 pysik = (summa * 0.8);
            }
            if (summa < 350 && summa > 250)
            {
                 pysik = (summa * 0.7);
            }
            if (summa > 350)
            {
                pysik = (summa * 0.6);
            }
            Console.WriteLine("Originaal hind on :" + summa);
             Console.WriteLine("Tavakliendi hind on:" + tavak);
            Console.WriteLine("pysikliendi hind on: " + pysik);
            





            Console.ReadLine();
        }
    }
}
