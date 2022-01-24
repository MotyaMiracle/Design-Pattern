using System;
using ClassLibraryS.Classes;
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

            IQuackBehavior Dquack = new DQuack();
            IQuackBehavior MuteQuack = new MuteQuack();
            IQuackBehavior Squeak = new Squeak();

            IFlyBehavior FlyWithWings = new FlyWithWings();
            IFlyBehavior FlyNoWay = new FlyNoWay();

            MD.SetFlyBehavior(FlyWithWings);
            MD.SetQuackBehavior(Dquack);

            RD.SetQuackBehavior(Dquack);
            RD.SetFlyBehavior(FlyWithWings);

            RubbD.SetFlyBehavior(FlyNoWay);
            RubbD.SetQuackBehavior(Squeak);

            DD.SetQuackBehavior(MuteQuack);
            DD.SetFlyBehavior(FlyNoWay);

            Duck[] ducks = new Duck[] { MD, RD, RubbD, DD };

            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.display());
                Console.WriteLine(duck.swim());
                Console.WriteLine(duck.performQuack());
                Console.WriteLine(duck.performFly());
            }
            Console.ReadKey();
        }
    }
}
