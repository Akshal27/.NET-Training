using System;

namespace Demo_app
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int n1, n2, add, sub;
            n1 = 10;
            n2 = 20;
            Console.WriteLine("Enter the value of n1: ");
            n1 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter the value of n2: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            add= n1 + n2;
            sub = n1 - n2;
            Console.WriteLine("Addition of two numbers: "+ add);
            Console.WriteLine("Subtraction of two numbers: " + sub);*/

            int studid;
            String st_name, Address;
            long contact;
            DateTime dob;
            char gender;
            Console.WriteLine("Enter the student id: ");
            studid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the student name: ");
            st_name = Console.ReadLine();
            Console.WriteLine("Enter the student Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Enter the student Contact Number: ");
            contact = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the student DOB: ");
            dob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the student gender: ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("***********Student Information***********");
            Console.WriteLine("Student id: "+studid);
            Console.WriteLine("Student name: " + st_name);
            Console.WriteLine("Student address: " + Address);
            Console.WriteLine("Student contact: " + contact);
            Console.WriteLine("Student DOB: " + dob);
            Console.WriteLine("Student Gender: " +gender);





        }
    }
}
