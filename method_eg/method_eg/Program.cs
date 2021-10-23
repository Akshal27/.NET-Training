using System;

namespace method_eg
{
    class Student
    {

        string stu_name,stu_address;
        int stu_age;

        public Student()
        {
            stu_name = "Unknown";
            stu_age = 0;
            stu_address = "Not available";
            Console.WriteLine(stu_name);
            Console.WriteLine(stu_age);
            Console.WriteLine(stu_address);

        }
        public void setInfo(string name,int age)
        {
            this.stu_name = name;
            this.stu_age = age;
            Console.WriteLine(this.stu_name);
            Console.WriteLine(this.stu_age);


        }
        public void setInfo(string name, int age,string address )
        {
            this.stu_name = name;
            this.stu_age = age;
            this.stu_address = address;
            Console.WriteLine(this.stu_name);
            Console.WriteLine(this.stu_age);
            Console.WriteLine(this.stu_address);

        }

        public static void Main(string[] args)
        {

            Student s1 = new Student();
            s1.setInfo("Akshal", 20, "Kanyakuamri");
            Student s2 = new Student();
            s2.setInfo("Jasino", 20);
          

            
        }
    }
}
