using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_object_model
{
    class Triangle : GeometricFigure
    {
        //The median perpendicular - серединный перпендикуляр
        protected double medianPerpendicularX;
        protected double medianPerpendicularY;

        public Triangle(double centerX, double centerY, double mPerperdicularX, double mPerperdicularY)
            : base (centerX, centerY)
        {
            medianPerpendicularX = mPerperdicularX;
            medianPerpendicularY = mPerperdicularY;
        }

        public void Draw()
        {
            Console.WriteLine("Triangle has drawn");
        }
    }
}
