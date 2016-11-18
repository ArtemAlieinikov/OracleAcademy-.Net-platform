using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_object_model._3_task
{
    class WrongDistanceException : Exception
    {
        public WrongDistanceException(string message) : base (message)
        { }
    }
}
