using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryS.Classes
{
    public class DQuack : IQuackBehavior
    {
        public string quack()
        {
            return "Кря кря кря";
        }
    }
}
