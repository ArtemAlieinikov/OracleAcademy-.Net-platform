using System;
using System.Text;

namespace Lesson_5_object_model
{
    class TelevisionSet
    {
        //For example, the TV provides 100 channels
        private byte currentChannel;

        public TelevisionSet()
        {
            currentChannel = 1;
        }

        public void NextChannel()
        { 
            if(currentChannel == 100)
            {
                currentChannel = 1;
            }
            else
            {
                ++currentChannel;
            }
        }

        public void PreviousChannel()
        {
            if(currentChannel == 1)
            {
                currentChannel = 100;
            }
            else
            {
                --currentChannel;
            }
        }

        public void SetChannelNumber(int number)
        {
            if((number <= 0) || (number > 100))
            {
                throw new FormatException("The number is incorrect");
            }
            else
            {
                currentChannel = (byte)number;
            }
        }
    }
}
