using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_object_model
{
    class GenericClass<T> where T : new()
    {
        private T element;

        public GenericClass(T element)
        {
            this.element = element;
        }

        public override string ToString()
        {
            return String.Format("Type - {0}, value - {1}.", element.GetType(), element);
        }
    }
}
