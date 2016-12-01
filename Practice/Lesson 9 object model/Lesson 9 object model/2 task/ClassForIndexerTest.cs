using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_object_model._2_task
{
    class ClassForIndexerTest
    {
        private int a;
        private int b;
        private int c;

        public ClassForIndexerTest(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int this[int index]
        {
            get
            {
                int result = 0;
                if (index <= 2 && index > 0)
                {
                    throw new FormatException("Wrong index. Index mast be between 0 and 2");
                }
                else
                {
                    if (index == 0)
                    {
                        result = a;
                    }
                    else if (index == 1)
                    {
                        result = b;
                    }
                    else
                    {
                        result = c;
                    }
                }

                return result;
            }
        }
    }
}
