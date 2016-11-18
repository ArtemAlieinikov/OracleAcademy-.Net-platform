using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_object_model._3_task
{
    public static class Speed
    {
        private static int time;
        private static int distance;

        public static int Time
        {
            get
            {
                return time;
            }
            set
            {
                if (value <= 0)
                {
                    throw new WrongTimeException("Time can not be equal or less than zero.");
                }
                else
                {
                    time = value;
                }
            }
        }

        public static int Distance
        {
            get
            {
                return distance;
            }
            set
            {
                if (value <= 0)
                {
                    throw new WrongDistanceException("Distance can not be equal or less than zero.");
                }
                else
                {
                    distance = value;
                }
            }
        }

        public static double Get()
        {
            return (double)distance / (double)time;
        }
    }
}
