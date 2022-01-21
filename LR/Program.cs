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
            RubberDuck RubbD = new RubberDuck();
            DecoyDuck DD = new DecoyDuck();
            Duck[] ducks = new Duck[] { MD, RD, RubbD, DD };

            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.display());
                Console.WriteLine(duck.swim());

                if (duck is IQuackable)
                {
                    Console.WriteLine((duck as IQuackable).quack());
                }

                if (duck is IFlyable)
                {
                    Console.WriteLine((duck as IFlyable).fly());
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
