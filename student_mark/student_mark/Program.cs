using System;

namespace student_mark
{
    class Program
    {
        static void Main(string[] args)
        {
            int  stu_roll_no,sub1, sub2, sub3, sub4, sub5, total;
            string stu_name;
            float percentage;
            Console.WriteLine("Enter student roll no: ");
            stu_roll_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student name: ");       
            stu_name = Console.ReadLine();       
            Console.WriteLine("Enter mark sub1 ");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mark sub2 ");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mark sub3 ");
            sub3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mark sub4 ");
            sub4= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mark sub5 ");
            sub5 = Convert.ToInt32(Console.ReadLine());

            total = sub1 + sub2 + sub3 + sub4 + sub5;

            percentage = total / 500 * 100;

            if (percentage > 90 && percentage <= 100)
                Console.WriteLine( stu_name+":"+ stu_roll_no+", Your grade is A");
            else if (percentage > 80 && percentage <= 90)
                Console.WriteLine(stu_name + ":" + stu_roll_no + ", Your grade is B");
            else if (percentage > 70 && percentage <= 80)
                Console.WriteLine(stu_name + ":" + stu_roll_no + ", Your grade is C");
            else
                Console.WriteLine(stu_name + ":" + stu_roll_no + ", Your grade is D");



        }
    }
}
