using System;

namespace bank_app
{
    class Banking
    {
        string cust_name, acc_num, address;
        long contact;
        static float depositamount=0;

        float withdraw_amnt = 0, interest=0;
        float bal = 0;

        public void CreateAccount()
        {

            Console.WriteLine("Enter customer acnt no: ");
            acc_num = Console.ReadLine();

            Console.WriteLine("Enter customer name: ");
            cust_name = Console.ReadLine();

            Console.WriteLine("Enter customer address: ");
            address = Console.ReadLine();

            Console.WriteLine("Enter customer contact ");
            contact = Convert.ToInt64(Console.ReadLine());
          
            Console.WriteLine("Account No" + acc_num);
            Console.WriteLine("Customer Name" + cust_name);
            Console.WriteLine("Address" + address);
            Console.WriteLine("Contact" + contact);
        
         


        }

        public float DepositAmnt()
        {
            Console.WriteLine("Enter amount to deposit: ");
            depositamount = Convert.ToInt64(Console.ReadLine());
            depositamount += depositamount;
            Console.WriteLine("Total deposited amount " + depositamount);
            return depositamount;


        }

        public void withdraw()
        {
            Console.WriteLine("Enter the withdrawal amount: ");
            withdraw_amnt = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Deposit amount: " + depositamount);
            Console.Write("Deposited amount: " + depositamount);
            bal = depositamount - withdraw_amnt;
            Console.WriteLine("After withdrawal the balance amnt: " + bal);
           
        }

        public float computeInterest()
        {
            float rate;

            Console.WriteLine("Enter the interest rate");

            rate = Convert.ToInt64(Console.ReadLine());

            interest = interest + (depositamount * rate / 100);
            
            float total = depositamount + interest;

            Console.WriteLine("rate of interest "+ rate);
            Console.WriteLine("Interest amount: " + interest);
            Console.WriteLine("Deposit amount: " + depositamount);
            Console.WriteLine("Total amount: " + total);    
            
            return interest;

        }

        public void displaybalance()
        {
            bal = depositamount - withdraw_amnt;
            Console.WriteLine("Balance amount" + bal);
          
        }

   
        static void Main(string[] args)
        {
            Banking b = new Banking();
            int input;
            do
            {

                Console.WriteLine("1. CreateAccount() \n 2. DepositAmnt() \n 3. withdraw()\n 4.computeInterest()\n 5.DisplayBalance\n ");
                Console.WriteLine("Enter input between (1-5): ");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        b.CreateAccount();
                        break;
                    case 2:
                        b.DepositAmnt();
                        break;
                    case 3:
                        b.withdraw();
                        break;
                    case 4:
                        b.computeInterest();
                        break;
                    case 5:
                        b.displaybalance();
                        break;
                    default:
                        Console.WriteLine("You have enter the wrong input");
                        break;
                }
            } while (input != 6);
        }
    }
}
