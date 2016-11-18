using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_object_model
{
    public static class StorageExtension
    {
        public static int Sum(this Storage obj)
        {
            return obj.FirstArgument + obj.SecondArgument;
        }

        public static int Minus(this Storage obj)
        {
            return obj.FirstArgument - obj.SecondArgument;
        }
    }
}
