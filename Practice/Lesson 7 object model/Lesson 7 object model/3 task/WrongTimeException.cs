using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_object_model._3_task
{
    class WrongTimeException : Exception
    {
        public WrongTimeException(string message) : base (message)
        { }
    }
}
