using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_11_object_model._2_task
{
    class Rabbit
    {
        public event Handler ChangedPosition;
        private int x;
        private int y;

        public Rabbit(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Go(int numberOfSteps)
        {
            for (int i = 0; i < numberOfSteps; ++i)
            {
                if (ChangedPosition != null)
                {
                    ChangedPosition(x, y);
                }

                Thread.Sleep(10000);
                x = ChoosePosition();
                y = ChoosePosition();
            }
        }

        private int ChoosePosition()
        {
            Random rnd = new Random();
            return rnd.Next(1,100);
        }
    }
}
