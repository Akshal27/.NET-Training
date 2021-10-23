using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*byte number;
            number = 35;
            int count = 10;
            float totalPrice = 20.00f;*/
            //Char needs to be closed in single quotes
            /*char character = 'A';*/
            //string needs to be closed in double quotes
            /*string firstName = "AJ JASINO";*/

            /*bool isWorking = false;*/

            //by default in variable byte will be taken as integer type
            var number = 35;
            var count = 10;
            var totalPrice = 20.00f;
            var character = 'A';
            var firstName = "AJ JASINO";
            var isWorking = false;
           

            //Write cw+ tab to type COnsole.WriteLIne



            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("Akshal Jasmine");



            //Formatting in C#

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);


            //Constants

            const float Pi = 2.17f;


            //Implicit Type conversion

            byte b = 1;   //1 byte
            int i = b;   //4 bytes , No data loss and compile error

            Console.WriteLine(i);

            //Let's reverse the previous execution 

            int n1 = 1000; //4 bytes
            //byte b1 = n1;  //1 bytes , Will get complie error
            byte b1 = (byte) n1;
            Console.WriteLine(b1);// it returns only 232 bcuz of the data loss

            try
            {

                //var num = "3400008";
                //int i = (int) num;
                //int j = Convert.ToByte(num);  //it gives exception

                //int j = Convert.ToInt32(num);
                //Console.WriteLine(j);

                string str = "true";
                bool bl = Convert.ToBoolean(str);
                Console.WriteLine(bl);




            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }


        }
    }
}
