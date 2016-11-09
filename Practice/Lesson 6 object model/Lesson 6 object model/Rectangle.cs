using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_object_model
{
    class Rectangle
    {
        private double X1;
        private double Y1;

        private double X2;
        private double Y2;

        public Rectangle(double X1, double X2, double Y1, double Y2)
        {
            this.X1 = X1;
            this.Y1 = Y1;

            this.X2 = X2;
            this.Y2 = Y2;
        }

        public override string ToString()
        {
            return String.Format("X1 - {0}, Y1 - {1}.\nX2 - {2}, Y2 - {3}", X1, Y1, X2, Y2);
        }

        public override int GetHashCode()
        {
            return (int)((X1 * 31) + (X2 * 37) + (Y1 * 41) + (Y2 * 43));
        }

        public override bool Equals(object obj)
        {
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            else
            { }

            Rectangle inspectedObject = (Rectangle)obj;
            return (inspectedObject.GetHashCode() == this.GetHashCode());
        }
    }
}
