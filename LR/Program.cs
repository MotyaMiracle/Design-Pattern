using System;
using ClassLibraryS;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck MD = new MallardDuck();
            RedheadDuck RD = new RedheadDuck();
            Duck[] duck = new Duck[] { MD, RD };

            for (int i = 0; i < duck.Length; i++)
            {
                Console.WriteLine(duck[i].quack());
                Console.WriteLine(duck[i].swim());
                Console.WriteLine(duck[i].display());
            }
            Console.ReadKey();
        }
    }
}
