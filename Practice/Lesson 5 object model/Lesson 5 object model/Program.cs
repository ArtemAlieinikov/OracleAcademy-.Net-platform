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
            Menu fridgeMenu = new Menu();
            LightBulb frigeBulb = new LightBulb();
            Fridge fridge = new Fridge("A13-50", "Samsung", frigeBulb);

            while(true)
            {
                fridgeMenu.Print(fridge);
                fridgeMenu.SetKey();
                if(fridgeMenu.Key == '1')
                {
                    fridge.TurnOnFridge();
                }
                else if(fridgeMenu.Key == '2')
                {
                    fridge.TurnOffFridge();
                }
                else if(fridgeMenu.Key == '3')
                {
                    fridge.SetFrostLevel(FridgeModeWork.Low);
                }
                else if (fridgeMenu.Key == '4')
                {
                    fridge.SetFrostLevel(FridgeModeWork.Middle);
                }
                else if (fridgeMenu.Key == '5')
                {
                    fridge.SetFrostLevel(FridgeModeWork.High);
                }
                else if (fridgeMenu.Key == '6')
                {
                    fridge.Defrost();
                }
                else if (fridgeMenu.Key == '7')
                {
                    fridge.TurnOnLight();
                }
                else if (fridgeMenu.Key == '8')
                {
                    fridge.TurnOffLight();
                }
                else if (fridgeMenu.Key == '9')
                {
                    break;
                }
            }
        }
    }
}
