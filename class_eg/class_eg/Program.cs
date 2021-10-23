using System;

namespace class_eg
{
    class BankAccount
    {
        string acntNum,acntName,address,email;
        static float acntBal=0;
        float withDrawCash, depositCash;
        long contact;


        public void getCustomerDetail()
        {
            Console.WriteLine("Enter your acnt num");
            acntNum = Console.ReadLine();

            Console.WriteLine("Enter your acnt name");
            acntName = Console.ReadLine();

            Console.WriteLine("Enter your address");
            address = Console.ReadLine();

            Console.WriteLine("Enter your acnt email");
            email = Console.ReadLine();

            Console.WriteLine("Enter your contact");
            contact = Convert.ToInt64(Console.ReadLine());
        }

  
        public void widthdrawCash()
        {
            Console.WriteLine("Enter your widthdrawal amnt");
            withDrawCash = Convert.ToInt32(Console.ReadLine());
            acntBal = acntBal - withDrawCash;
            if (acntBal <= 1000)
            {
                Console.WriteLine("You can't withdraw");
                acntBal = depositCash;
                Console.WriteLine("Your reaminang balance is: " + acntBal);
                //break;
            }

            else
            {
                Console.WriteLine("You have widthdrawed your amount");
                Console.WriteLine("Your reaminang balance is: " + acntBal);
            }
                
              
        }

        public void DepositCash()
        {
            Console.WriteLine("Enter your deposit amnt");
            depositCash = Convert.ToInt32(Console.ReadLine());
            acntBal = acntBal + depositCash;
            Console.WriteLine("Your amount is deposited and the balance is: " + acntBal);

        }


        public void ShowBalance()
        {
            Console.WriteLine(acntBal);
        }


        public void AccountDetails()
        {
            Console.WriteLine("Acnt Name: "+acntName);
            Console.WriteLine("Acnt Num: " + acntNum);
            Console.WriteLine("contact " + contact);
            Console.WriteLine("Address " + address);
            Console.WriteLine("email " + email);
            Console.WriteLine("Balance " + acntBal);
        }


  
        static void Main(string[] args)
        {
            BankAccount user1 = new BankAccount();
            int input;
            do
            {
                Console.WriteLine(" 1.Get Customer Details\n 2.Width Draw Cash\n 3.Deposit Cash\n 4.Show Balance\n");              
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {

                    case 1:
                        user1.getCustomerDetail();
                        break;
                    case 2:
                        user1.widthdrawCash();
                        break;
                    case 3:
                        user1.DepositCash();
                        break;
                    case 4:
                        user1.ShowBalance();
                        break;

                    default:
                        Console.WriteLine("You entered the wrong value");
                        break;
                }
            } while( input != 5);

        }
    }
}


