using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_object_model._4_task
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public abstract void Bite();
    }
}
