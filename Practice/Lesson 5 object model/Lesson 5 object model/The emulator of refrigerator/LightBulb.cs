using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_object_model.The_emulator_of_refrigerator
{
    public class LightBulb : IGetInfo
    {
        private bool state;

        public LightBulb()
        { }

        public void On()
        {
            state = true;
        }

        public void Off()
        {
            state = false;
        }

        public string GetInfo()
        {
            string state;

            if(this.state == true)
            {
                state = "On";
            }
            else
            {
                state = "Off";
            }


            return String.Format("Bulb status: {0}.", state);
        }
    }
}
