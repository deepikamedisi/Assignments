using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class Account

    {
        public int Accountnum;
        public string CustomerName;
        public string AccountType;

        public  Account(int accountnum,string customerName,string accounttype)
        {
            this.Accountnum = accountnum;
            this.CustomerName = customerName;
            this.AccountType = accounttype;

        }
        public void display()
        {
            Console.WriteLine($"Accountnum: {Accountnum}, CustomerName: {CustomerName}, Accounttype: {AccountType}");
        }

        public static void credit()
        {
            Console.WriteLine("Enter the amount to be deposited: ");
            int DepositAmount = Convert.ToInt32(Console.ReadLine());
            int balance=500000;
            if (DepositAmount <= 0)
            {
                Console.WriteLine("Entered amount is invalid");
            }
            else
            {
                 balance = balance + DepositAmount;

                Console.WriteLine("Total Balance is " + balance);
            }
        }
        public static void debit()
        {
            Console.WriteLine("Enter the amount to be debited: ");
            int debitAmount = Convert.ToInt32(Console.ReadLine());
            int balance = 10000;
            if (debitAmount == 0 || debitAmount > 10000)
            {
                Console.WriteLine("Entered amount is invalid");
            }
            else
            {
                balance = balance - debitAmount;

                Console.WriteLine("Total Balance is " + balance);
            }
        }
        
        class Program
        {
            
            public static void Main()
            {

                Account info = new Account( 1236789268 , "deepika", "savings account");
                info.display();
                Console.WriteLine("Choose Transaction Type: ");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdrawal");

                Console.WriteLine("Enter your transaction type 1 or 2: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Account.credit();
                }
                else if (choice == 2)
                {
                    Account.debit();
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                }

                Console.ReadLine();
            }
        }
    }
}
