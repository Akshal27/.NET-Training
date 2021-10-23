using System;

namespace static_class
{
    class Employee
    {
        static int empid;
        static string empname;
        int salary;
        string department;
        string email;
        
        //Default Constructor
        public Employee()
        {
            Console.WriteLine("I'm default constrcutor");
        }
        //Parameterized constructor

        public Employee(string email)
        {
            this.email = email;
            Console.WriteLine("Your email"+email);


        }
        public Employee(int sal,string dept)
        {
            this.salary = sal;
            this.department = dept;
            Console.WriteLine("Your email" + salary);
            Console.WriteLine("Your email" + department);
        }
        public void display()
        {
            Console.WriteLine("Employee id: " + empid);
            Console.WriteLine("Employee Name: " + empname);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Department : " + department);
        }

        public void hello()
        {
            Console.WriteLine("Hello, I'm non static member");
        }
             

       
        static void Main(string[] args)
        {
            Employee e1 = new Employee(2000, "Marketing");
            Employee e2 = new Employee("a@gmail.com");

          
        }
    }
}
