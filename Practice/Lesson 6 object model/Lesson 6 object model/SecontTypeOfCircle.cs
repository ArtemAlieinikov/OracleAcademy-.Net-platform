using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_object_model
{
    class SecontTypeOfCircle : GeometricFigure
    {
        private double radius;

        public SecontTypeOfCircle(double centerX, double centerY, double radius)
            : base (centerX, centerY)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine("Circle has drawn");
        }
    }
}
