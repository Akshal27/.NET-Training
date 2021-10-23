using System;

namespace Time_to_second
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour, min, sec, value, num1,num2;
            Console.WriteLine("Enter the hour value");
            hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the minutes value");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value");
            sec= Convert.ToInt32(Console.ReadLine());

            value = hour * 3600 + min * 60 + sec;
            Console.WriteLine("The seconds value is: " + value);

            Console.WriteLine("Enter the num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The swapped values are: " + num1 + "," + num2);
            
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            

            Console.WriteLine("The swapped values are: " + num1 + "," + num2);


        }
    }
}
