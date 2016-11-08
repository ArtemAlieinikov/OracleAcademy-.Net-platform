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

        public char Key
        {
            get
            {
                return key;
            }
        }

        public void Print(IGetInfo cuurentDevice)
        {
            Console.Clear();
            Console.WriteLine(cuurentDevice.GetInfo());
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
            Console.WriteLine("9 - Выйти");
        }

        public void SetKey()
        {
            key = Console.ReadKey().KeyChar;
        }
    }
}
