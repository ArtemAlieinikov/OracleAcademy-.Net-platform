using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_object_model._1_task
{
    class Pong
    {
        public event PingPongDelegate Ponged;

        public void GoPong()
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Pong");

            if (Ponged != null)
            {
                Ponged();
            }
        }
    }
}
