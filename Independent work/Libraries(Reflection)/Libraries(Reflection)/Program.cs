using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries_Reflection_
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorFullClass testClass = new ColorFullClass();
            ClassProperties.ColorPrint(testClass);
        }
    }
}
