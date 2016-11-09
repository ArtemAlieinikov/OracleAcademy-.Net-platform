using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_object_model.The_emulator_of_refrigerator
{
    class Menu
    {
        private char key;
        private Fridge currentFridge;

        public Fridge CurrentFridge
        {
            get
            {
                return currentFridge;
            }
            set
            {
                if (value is Fridge)
                {
                    currentFridge = value;
                }
            }
        }

        public char Key
        {
            get
            {
                return key;
            }
        }

        public Menu(Fridge currentFridge)
        {
            CurrentFridge = currentFridge;
        }

        public void Run()
        {
            while (true)
            {
                Clear();
                PrintInfoAboutDevice();
                Print();
                SetKey();
                ImplementationOfActions();
                if (Key == '0')
                {
                    Clear();
                    break;
                }
            }
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void PrintInfoAboutDevice()
        {
            Console.WriteLine(CurrentFridge.ToString());
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Нажмите клавишу для выполнения действия:");
            Console.WriteLine("1 - Включить холодильник");
            Console.WriteLine("2 - Выключить холодильник");
            Console.WriteLine("3 - Установить слабый холод");
            Console.WriteLine("4 - Установить средний холод");
            Console.WriteLine("5 - Установить высокий холод");
            Console.WriteLine("6 - Разморозить холодильник");
            Console.WriteLine("7 - Включить лампочку");
            Console.WriteLine("8 - Выключить лампочку");
            Console.WriteLine("0 - Выйти");
        }

        public void SetKey()
        {
            key = Console.ReadKey().KeyChar;
        }

        public void ImplementationOfActions()
        {
            if (Key == '1')
            {
                CurrentFridge.TurnOnFridge();
            }
            else if (Key == '2')
            {
                CurrentFridge.TurnOffFridge();
            }
            else if (Key == '3')
            {
                CurrentFridge.SetFrostLevel(FridgeModeWork.Low);
            }
            else if (Key == '4')
            {
                CurrentFridge.SetFrostLevel(FridgeModeWork.Middle);
            }
            else if (Key == '5')
            {
                CurrentFridge.SetFrostLevel(FridgeModeWork.High);
            }
            else if (Key == '6')
            {
                CurrentFridge.Defrost();
            }
            else if (Key == '7')
            {
                CurrentFridge.TurnOnLight();
            }
            else if (Key == '8')
            {
                CurrentFridge.TurnOffLight();
            }
        }
    }
}
