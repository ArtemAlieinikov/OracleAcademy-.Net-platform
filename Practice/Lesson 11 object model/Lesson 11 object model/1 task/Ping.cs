using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_object_model._1_task
{
    class Ping
    {
        public event PingPongDelegate Pinged;

        public void GoPing()
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Ping");

            if (Pinged != null)
            {
                Pinged();
            }
        }
    }
}
