using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryS
{
    public class RedheadDuck : Duck
    {
        public override string display()
        {
            return $"{GetType()} | {quackBehavior.GetType()} | {flyBehavior.GetType()}";
        }
    }
}
