using System;

namespace greatest_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2,n3;
            Console.WriteLine("Enter the num1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num2: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num2: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n2)
                Console.WriteLine("N1 is the greater number");
            else if (n2 > n1 && n2 > n3)
                Console.WriteLine("N2 is the greater number");
            else 
                Console.WriteLine("N3 is the greater number");
        }
    }
}
