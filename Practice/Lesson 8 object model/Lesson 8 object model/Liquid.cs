using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_object_model
{
    public class Liquid
    {
        private double volume;
        private string[] chemicalComposition;

        public double Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Volume cannot be less than zero.");
                }
                else
                {
                    volume = value;
                }
            }
        }

        public string[] ChemicalComposition
        {
            get
            {
                return chemicalComposition;
            }
            private set
            {
                chemicalComposition = value;
            }
        }

        public Liquid(double volume, string[] chemicalComposition)
        {
            Volume = volume;
            ChemicalComposition = chemicalComposition;
        }

        public static Liquid operator +(Liquid fLiquid, Liquid sLiquid)
        {
            double resultVolume = fLiquid.Volume + sLiquid.Volume;
            int sizeOresultArray = fLiquid.ChemicalComposition.Length + sLiquid.ChemicalComposition.Length;

            string[] resultComposition = new string[sizeOresultArray];

            //We can use this part
            fLiquid.ChemicalComposition.CopyTo(resultComposition, 0);
            sLiquid.ChemicalComposition.CopyTo(resultComposition, fLiquid.ChemicalComposition.Length);

            //Or this part
            //Array.Copy(fLiquid.ChemicalComposition, 0, resultComposition, 0, fLiquid.ChemicalComposition.Length);
            //Array.Copy(sLiquid.ChemicalComposition, 0, resultComposition, fLiquid.ChemicalComposition.Length, sLiquid.ChemicalComposition.Length);

            Liquid resultLiquid = new Liquid(resultVolume, resultComposition);

            return resultLiquid;
        }

        public static Liquid[] operator /(Liquid fLiquid, double divideVolume)
        {
            double resultVolume = fLiquid.Volume / divideVolume;
            Liquid[] resultLiquids = new Liquid[2];

            resultLiquids[0] = new Liquid(resultVolume, fLiquid.ChemicalComposition);
            resultLiquids[1] = new Liquid(fLiquid.Volume - resultVolume, fLiquid.ChemicalComposition);

            return resultLiquids;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("Volume of liquid - {0:#.##}", Volume));

            for (int i = 0; i < ChemicalComposition.Length; ++i)
            {
                if (i == ChemicalComposition.Length - 1)
                {
                    result.Append(ChemicalComposition[i] + ".");
                    break;
                }
                result.Append(ChemicalComposition[i] + ", ");
            }

            return result.ToString();
        }
    }
}
