using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_11_object_model._1_task;
using Lesson_11_object_model._2_task;

namespace Lesson_11_object_model
{
    class Program
    {
        static void Main(string[] args)
        {
            Hunter Bob = new Hunter();
            Rabbit Jack = new Rabbit(10, 15);
            Jack.ChangedPosition += Bob.FollowAnimal;

            Jack.ChangedPosition += delegate(int x, int y)
            {
                Console.WriteLine("I changed position");
            };

            Jack.ChangedPosition += (int x, int y) => Console.WriteLine("Now i am at new position");

            Jack.Go(10);
        }
    }
}
