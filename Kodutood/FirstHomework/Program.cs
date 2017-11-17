using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            int arv1 = 0;

            Console.WriteLine("Arva ära suvaline number");
            Console.WriteLine();
            Console.WriteLine("Kirjuta number 1-100");
            Console.WriteLine();
           
            while (arv1 != randomNumber)
            {

                arv1 = int.Parse(Console.ReadLine());

                if (arv1 > randomNumber)
                {

                    Console.WriteLine("sinu pakutud arv on suurem, arva uuesti");
                    continue;
                }
                if (arv1 < randomNumber)
                {
                    Console.WriteLine("sinu pakutud arv on väiksem, arva uuesti");
                    continue;
                }
                if (arv1 == randomNumber)
                {
                    break;
                }





              



            }
            Console.WriteLine("arvasid õigesti");

            Console.ReadLine();












            Console.ReadLine();
        }
    }
}
