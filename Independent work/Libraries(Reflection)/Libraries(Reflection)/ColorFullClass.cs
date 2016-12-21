using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries_Reflection_
{
    class ColorFullClass
    {
        [PropertyColorAttribute(ConsoleColor.Green)]
        private int GreenProperty { get; set; }

        [PropertyColorAttribute(ConsoleColor.Red)]
        protected string RedProperty { get; set; }

        [PropertyColorAttribute(ConsoleColor.Yellow)]
        internal bool YellowProperty { get; set; }

        [PropertyColorAttribute(ConsoleColor.Cyan)]
        protected internal double CyanProperty { get; set; }

        [PropertyColorAttribute(ConsoleColor.Magenta)]
        public object MagentaProperty { get; set; }

        [PropertyColorAttribute(ConsoleColor.Blue)]
        public object BlueProperty { get; set; }
    }
}
