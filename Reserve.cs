using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Banking
{
    class Reserve : Account
    {
        //Reserve Feilds
        private string accountType = "Reserve Account";

        private int accountNumber = 32345;
        private float balance = 1000.00f;

        //Reserve Methods
        public override void PrintBalance()
        {
            Console.WriteLine("Your current reserve account balance is $" + balance);
        }


        public override float Credit(float creditAmmount)
        {
            Console.WriteLine("Enter how much you would like to deposit");
            creditAmmount = float.Parse(Console.ReadLine());
            this.balance += creditAmmount;
            return creditAmmount;

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
            Console.WriteLine("Your reserve account number is " + accountNumber);
            Console.WriteLine("Your reserve account balance is $" + balance);
        }


    }//End of Reserve Class
}
