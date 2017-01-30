using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Banking
{
    class Savings : Account
    {
        //Savings Feilds
        private string accountType = "Savings Account";

        private int accountNumber = 22345;
        private float balance = 10000.00f;

        //Savings Methods
        public override void PrintBalance()
        {
            Console.WriteLine("Your current savings account balance is $" + balance);
        }

        public override float Credit(float creditAmmount)
        {
            Console.WriteLine("Enter how much you would like to deposit");
            creditAmmount = float.Parse(Console.ReadLine());
            this.balance += creditAmmount;
            return balance;
        }

        public override float Debit(float debitAmmount)
        {
            Console.WriteLine("Enter an ammount to withdrawl.");
            debitAmmount = float.Parse(Console.ReadLine());
            this.balance -= debitAmmount;
            return balance;
        }

        public override void DisplayAccountDetails()
        {
            Console.WriteLine(accountType);
            Console.WriteLine("Your savings account number is " + accountNumber);
            Console.WriteLine("Your savings account balance is " + balance);
        }
    }//End of Savings Class
}
