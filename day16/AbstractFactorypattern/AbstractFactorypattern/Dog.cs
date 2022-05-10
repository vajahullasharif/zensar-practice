using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorypattern
{
    public class Dog : Animal
    {
        public string speak()
        {
            return "Bow Bow";
        }
    }
}
