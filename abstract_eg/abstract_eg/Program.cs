using System;

namespace abstract_eg
{
    public abstract class Student
    {
        public void Std()
        {
            Console.WriteLine("std VI");
        }
        public void Section()
        {
            Console.WriteLine("Section B");
        }
        public abstract void AddStudent(string name);
        public abstract void AddAge(string age);

        class Detail : Student
        {
            string st_age, st_name;
            public override void AddAge(string age)
            {
                this.st_age = age;
                Console.WriteLine(this.st_age);
                throw new NotImplementedException();
            }

            public override void AddStudent(string name)
            {
                this.st_name = name;
                Console.WriteLine(this.st_name);
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
            Detail d = new Detail();
            d.AddAge("20");
            d.AddStudent("Akshal");

        }


    }
}
