using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_object_model
{
    class GeometricFigure
    {
        protected double centerX;
        protected double centerY;

        public GeometricFigure(double centerX, double centerY)
        {
            this.centerX = centerX;
            this.centerY = centerY;
        }
    }
}
