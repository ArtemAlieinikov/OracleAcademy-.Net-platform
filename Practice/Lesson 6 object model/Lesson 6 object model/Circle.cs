using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_object_model
{
    class Circle
    {
        private double centerX;
        private double centerY;
        private double radius;

        public Circle()
        { }

        public Circle(double radius, double centerX, double centerY)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * radius;
        }

        //Circumference - длинна окружности
        public double GetCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public Circle GetCircle()
        {
            return new Circle(this.radius, this.centerX, this.centerY);
        }

        public Circle GetCircle(double radius, double centerX, double centerY)
        {
            return new Circle(radius, centerX, centerY);
        }

        public bool IsHit(double dotX, double dotY)
        {
            if (((centerX - dotX) * 2 + (centerY - dotY) * 2) <= (radius * 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return String.Format("The center coordinates x: {0}, y: {1}, radius: {2}", centerX, centerY, radius);
        }
    }
}
