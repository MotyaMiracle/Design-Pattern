using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryS
{
    public class RubberDuck : Duck, IQuackable
    {
        public string quack()
        {
            return "quack " + this.GetType();
        }
        public override string display()
        {
            return "display " + this.GetType();
        }
    }
}
