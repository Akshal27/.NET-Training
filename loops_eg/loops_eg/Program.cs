using System;

namespace loops_eg
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] name = { "Aksh", "Jas", "Jasino" };

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }


            foreach (string i in name)
            {
                Console.WriteLine(i);
            }*/


            int sum = 0;
            for(int i = 10; i <= 100; i++)
            {
                if (i % 2 == 0 )
                {
                    sum = sum + i;
                    Console.WriteLine("the sum = " + sum);

                }
            }

            int  fact = 1;
         
            for (int j = 1; j <=4; j++)
            {
                fact = fact * j;
            }
            Console.Write("Factorial of  4  is: " + fact);


            int n1 = 0, n2 = 1, n3,n4;

            Console.WriteLine("Enter the Num");
           
            n4 = Convert.ToInt32(Console.ReadLine());

            if (n4 == n1)
                Console.WriteLine(n1);
            else if (n4 == n2)

                Console.WriteLine(n2);
            else
                for (int i = 2; i < n4; ++i)
                {
                    n3 = n1 + n2;
                    Console.WriteLine( n3 + " ");
                    n1 = n2;
                    n2 = n3;
                }


        }
    }
}
