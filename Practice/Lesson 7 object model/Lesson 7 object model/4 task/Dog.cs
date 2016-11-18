using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_object_model._4_task
{
    class Dog : Animal
    {
        public override void Bite()
        {
            Console.WriteLine("Dog {0} bites", Name);
        }
    }
}
