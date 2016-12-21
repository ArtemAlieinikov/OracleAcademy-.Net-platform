using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries_Reflection_
{
    [AttributeUsage(AttributeTargets.Property)]
    class PropertyColorAttribute : Attribute
    {
        public ConsoleColor propColor;

        public PropertyColorAttribute(ConsoleColor color)
        {
            propColor = color;
        }
    }
}
