using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_object_model
{
    class Square
    {
        public double sideLength { get; set; }

        public virtual double GetArea()
        {
            return sideLength * 2;
        }
    }
}
