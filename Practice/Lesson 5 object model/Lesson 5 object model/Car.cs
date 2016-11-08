using System;
using System.Text;

namespace Lesson_5_object_model
{
    class Car
    {
        private int yearOfBuilding;
        protected string name;
        protected internal string mark;
        internal int mileage;
        public int displacement;

        /*
         * private - access only from base class
         * protected - access only from base class and heirs classes
         * protected internal - access only from base class, heirs classes and from same assembly
         * internal - access from same assembly
         * public - access from same assembly and from other assembly
         */
    }
}
