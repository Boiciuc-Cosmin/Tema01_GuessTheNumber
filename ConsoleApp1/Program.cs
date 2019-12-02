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
            int nr=0;
            Random rand = new Random();
            int r = rand.Next(0, 101);
            Console.WriteLine("Numarul random generat {0}",r);
            Console.WriteLine("Guess the number");
            do
            {
                Console.Write("Introduceti un numar intre [0,100]: ");
                string numar = Console.ReadLine();
                nr = int.Parse(numar);

                if (nr < r)
                    Console.WriteLine("Numarul introdus este mai mic");
                if (nr > r)
                    Console.WriteLine("Numarul introdus este mai mare");
            }
            while (nr != r);
                
            Console.WriteLine("Ati ghicit numarul");
          
           
        }
    }
}
