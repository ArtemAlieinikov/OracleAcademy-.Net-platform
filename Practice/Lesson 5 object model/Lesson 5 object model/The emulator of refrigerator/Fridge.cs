using System;
using System.Text;

namespace Lesson_5_object_model.The_emulator_of_refrigerator
{
    public class Fridge : IGetInfo
    {
        private string model;
        private string brandName;
        private bool isOn;

        private FridgeModeWork frostLevel;
        private int glaciationLevel;
        private bool glaciation;

        private LightBulb bulb;

        public LightBulb Bulb
        {
            get
            {
                return bulb;
            }

            set
            {
                if(value is LightBulb)
                {
                    bulb = value;
                }
            }
        }

        public Fridge(string model, string brandName, LightBulb bulb)
        {
            this.model = model;
            this.brandName = brandName;

            isOn = false;
            glaciationLevel = 0;
            glaciation = false;

            frostLevel = FridgeModeWork.Middle;
            this.bulb = bulb;
        }

        public void TurnOnFridge()
        {
            if(isOn == false)
            {
                this.AddGlaciationLevel();
                this.CheckGlaciation();
            }
            else { }

            isOn = true;
            Bulb.On();
        }

        private void AddGlaciationLevel()
        {
            if(frostLevel == FridgeModeWork.Low)
            {
                glaciationLevel += 5;
            }
            else if(frostLevel == FridgeModeWork.Middle)
            {
                glaciationLevel += 10;
            }
            else
            {
                glaciationLevel += 20;
            }
        }

        private void CheckGlaciation()
        {
            if(glaciationLevel > 100)
            {
                glaciationLevel = 101;
                glaciation = true;
            }
            else if(glaciationLevel < 0)
            {
                glaciationLevel = 1;
                glaciation = false;
            }
        }

        public void TurnOffFridge()
        {
            if(isOn == true)
            {
                this.PutDownGlaciationLevel();
                this.CheckGlaciation();
            }
            else { }

            isOn = false;
            Bulb.Off();
        }

        private void PutDownGlaciationLevel()
        {
            if (frostLevel == FridgeModeWork.Low)
            {
                glaciationLevel -= 2;
            }
            else if (frostLevel == FridgeModeWork.Middle)
            {
                glaciationLevel -= 4;
            }
            else
            {
                glaciationLevel -= 8;
            }
        }

        public void Defrost()
        {
            glaciationLevel = 1;
            glaciation = false;
        }

        public void SetFrostLevel(FridgeModeWork frostLevel)
        {
            this.frostLevel = frostLevel;
        }

        public void TurnOnLight()
        {
            if(isOn == true)
            {
                Bulb.On();
            }
        }

        public void TurnOffLight()
        {
            if (isOn == true)
            {
                Bulb.Off();
            }
        }

        public string GetInfo()
        {
            StringBuilder resultBuilder = new StringBuilder();

            resultBuilder.Append("Model: " + model + ", Brand name: " + brandName + ". \n");

            if(this.isOn == true)
            {
                resultBuilder.Append("State: is On, ");
            }
            else
            {
                resultBuilder.Append("State: is Off, ");
            }

            if(this.frostLevel == FridgeModeWork.Low)
            {
                resultBuilder.Append("Low frost level.\n");
            }
            else if(this.frostLevel == FridgeModeWork.Middle)
            {
                resultBuilder.Append("Middle frost level.\n");
            }
            else
            {
                resultBuilder.Append("High frost level.\n");
            }

            resultBuilder.Append("Glaciation level - " + glaciationLevel + "%, ");
            resultBuilder.Append("glaciation - " + glaciation + ".\n");

            resultBuilder.Append(Bulb.GetInfo());

            string result = resultBuilder.ToString();
            return result;
        }
    }
}
