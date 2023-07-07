using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class enumdemo
    {
        enum Colors { Red, Green, Blue };
        
        public void Display()
        {
            Colors colors1 = Colors.Red;
            Colors colors2 = Colors.Green;
            Colors colors3 = Colors.Blue;
            Console.WriteLine(colors3);

        }
        
    }

    
}
