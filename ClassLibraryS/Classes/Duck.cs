using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryS
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;
        
        public string performQuack()
        {
            return quackBehavior.quack();
        }
        public string performFly()
        {
            return flyBehavior.fly();
        }
        public string swim()
        {
            return "Буль буль буль ";
        }
        public void SetFlyBehavior(IFlyBehavior flybeh)
        {
            flyBehavior = flybeh;
        }
        public void SetQuackBehavior(IQuackBehavior quackbeh)
        {
            quackBehavior = quackbeh;
        }
        abstract public string display();
    }
}
