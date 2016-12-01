using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_object_model._1_task
{
    class Light : ISwitchable
    {
        private bool state;

        public void TurnOn()
        {
            if (state == false)
            {
                state = true;
            }
            else { }
        }

        public void TurnOff()
        {
            if (state == true)
            {
                state = false;
            }
            else { }
        }

        public override string ToString()
        {
            string stringState = state ? "On" : "Off";
            return String.Format("Light is {0}", stringState);
        }
    }
}
