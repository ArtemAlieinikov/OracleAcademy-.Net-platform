using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_object_model
{
    class Cube : Square
    {
        public override double GetArea()
        {
            return 6 * sideLength * 2;
        }
    }
}
