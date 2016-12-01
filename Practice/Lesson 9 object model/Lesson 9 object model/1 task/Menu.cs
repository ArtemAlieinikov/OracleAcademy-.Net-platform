using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_object_model._1_task
{
    class Menu
    {
        private string action;
        public Saw currentSaw { get; set; }
        public Light currentLight { get; set; }

        public void Start()
        {
            while (true)
            {
                Clear();
                PrintInfoAboutDevices();
                PrintActions();
                SetCommand();
                DoAction();

                if (action == "Exit")
                {
                    Clear();
                    break;
                }
            }
        }

        private void SetCommand()
        {
            action = Console.ReadLine();
        }

        private void Clear()
        {
            Console.Clear();
        }

        private void PrintInfoAboutDevices()
        {
            Console.WriteLine(currentLight.ToString());
            Console.WriteLine(currentSaw.ToString());
        }

        private void PrintActions()
        {
            Console.WriteLine("Write \"Saw is On\" to turn on saw.");
            Console.WriteLine("Write \"Saw is Off\" to turn on saw.");
            Console.WriteLine("Write \"Light is On\" to on light.");
            Console.WriteLine("Write \"Light is Off\" to on light.");
            Console.WriteLine("Write \"Exit\" to close the dialog.");
        }

        private void DoAction()
        {
            if (action == "Saw is On")
            {
                currentSaw.TurnOn();
            }

            if (action == "Saw is Off")
            {
                currentSaw.TurnOn();
            }

            if (action == "Light is On")
            {
                currentLight.TurnOn();
            }

            if (action == "Light is Off")
            {
                currentLight.TurnOff();
            }
        }
    }
}
