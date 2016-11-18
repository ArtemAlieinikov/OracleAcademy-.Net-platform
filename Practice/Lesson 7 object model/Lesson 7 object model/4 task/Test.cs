using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_object_model._4_task
{
    class Test
    {
        public void Print(int number)
        {
            if ((number <= 0) || (number > 3))
            {
                throw new FormatException("Number of test is incorrect");
            }
            else { }

            switch (number)
            {
                case 1:
                    {
                        FirstVersion();
                        break;
                    }
                case 2:
                    {
                        SecondVersion();
                        break;
                    }
                case 3:
                    {
                        ThirdVersion();
                        break;
                    }
            }
        }

        private void FirstVersion()
        {
            Animal[] arrAnimal = new Animal[6];
            arrAnimal[0] = new Dog { Name = "Шарик" };
            arrAnimal[1] = new Cat { Name = "Царапа" };
            arrAnimal[2] = new Cat { Name = "Ленивец" };
            arrAnimal[3] = new Dog { Name = "Джек" };
            arrAnimal[4] = new Cat { Name = "Черныш" };
            arrAnimal[5] = new Dog { Name = "Арчи" };

            foreach(Animal item in arrAnimal)
            {
                item.Bite();
                Cat tempCat = item as Cat;

                if (tempCat != null)
                {
                    tempCat.Purr();
                }
                else { }
            }
        }

        private void SecondVersion()
        {
            Animal[] arrAnimal = new Animal[6];
            arrAnimal[0] = new Dog { Name = "Шарик" };
            arrAnimal[1] = new Cat { Name = "Царапа" };
            arrAnimal[2] = new Cat { Name = "Ленивец" };
            arrAnimal[3] = new Dog { Name = "Джек" };
            arrAnimal[4] = new Cat { Name = "Черныш" };
            arrAnimal[5] = new Dog { Name = "Арчи" };

            foreach (Animal item in arrAnimal)
            {
                item.Bite();

                if (item is Cat)
                {
                    ((Cat)item).Bite();
                }
                else { }
            }
        }

        private void ThirdVersion()
        {
            Animal[] arrAnimal = new Animal[6];
            arrAnimal[0] = new Dog { Name = "Шарик" };
            arrAnimal[1] = new Cat { Name = "Царапа" };
            arrAnimal[2] = new Cat { Name = "Ленивец" };
            arrAnimal[3] = new Dog { Name = "Джек" };
            arrAnimal[4] = new Cat { Name = "Черныш" };
            arrAnimal[5] = new Dog { Name = "Арчи" };

            foreach (Animal item in arrAnimal)
            {
                item.Bite();

                try
                {
                    Cat tempCat = (Cat)item;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
