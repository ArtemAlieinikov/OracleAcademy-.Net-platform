using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_5_object_model.The_emulator_of_refrigerator;

namespace Lesson_5_object_model
{
    class Program
    {
        static void Main(string[] args)
        {
            LightBulb frigeBulb = new LightBulb();
            Fridge fridge = new Fridge("A13-50", "Samsung", frigeBulb);
            Menu fridgeMenu = new Menu(fridge);

            fridgeMenu.Run();
        }
    }
}
