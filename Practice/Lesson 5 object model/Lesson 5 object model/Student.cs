using System;
using System.Text;


namespace Lesson_5_object_model
{
    public class Student
    {
        /*В начале создается обьект и поля инициализируются значениями по умолчанию, 
        и только потом срабатывает конструктор, в этом так же отличительная черта структуры от класса*/
        private string name;
        private int course;
        private bool isGrant;

        public Student(string name, int course, bool isGrant)
        {
            this.name = name;
            this.course = course;
            this.isGrant = isGrant;
        }

        public Student(string name)
        {
            this.name = name;
        }

        public Student(string name, int course)
        {
            this.name = name;
            this.course = course;
        }
    }
}
