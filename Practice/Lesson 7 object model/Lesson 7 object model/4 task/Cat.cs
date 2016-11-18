using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_object_model._4_task
{
    class Cat : Animal
    {
        public override void Bite()
        {
            Console.WriteLine("Cat {0} bites", Name);
        }

        public void Purr()
        {
            Console.WriteLine("Cat {0} puurs", Name);
        }
    }
}
