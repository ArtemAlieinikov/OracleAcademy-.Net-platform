using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_object_model
{
    class AudioPlayer
    {
        private int volume;

        public int Volume
        {
            get
            {
                return volume;
            }

            set
            {
                if((value < 0) || (value > 100))
                {
                    volume = 0;
                }
                else
                {
                    volume = value;
                }
            }
        }
    }
}
