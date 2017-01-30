using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Banking
{
    class Checking : Account
    {
        //Checking Feilds
        private string accountType = "Checking Account";

        private int accountNumber = 12345;
        private float balance = 2000.00f;

        //Checking properties
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public float Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        //Constructor

            public Checking()
        {

        }



        //Checking Methods
        public override void PrintBalance()
        {
            Console.WriteLine("Your current checking account balance is $" + balance);
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
            Console.WriteLine("Your checking account number is " + accountNumber);
            Console.WriteLine("Your checking account balance is $" + balance);
            Console.WriteLine(DateTime.Now);
        }


        //Do not understand how streamWriter works please explain after grading

        //public void CheckingStreamWriter()
        //{
        //    StreamWriter streamChecking = new StreamWriter("Checking account.txt");

        //}




    }//End of Checking Class
}
