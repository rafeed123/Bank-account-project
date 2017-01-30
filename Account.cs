using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Banking
{
    class Account
    {
        //Feilds
        private string firstName;
        private string lastName;
        private string accountType;

        private int accountNumber;
        private float balance;


        //Properties

        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }

        }

        //Constructors

        public Account()
        {

        }



        //Methods
        public virtual void Intro()
        {
            Console.WriteLine("Welcome to Virtual Banking press enter to continue");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("To log in please enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Hello " + firstName + " please enter your last name to access your accounts.");
            string lastName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(firstName + " " + lastName + " Access granted");
            Console.WriteLine();

        }

        public virtual void PrintBalance()
        {
            Console.WriteLine("Your current balance is " + balance);
        }


        public virtual float Credit(float creditAmmount)
        {
           
            this.balance += creditAmmount;
            return creditAmmount;
            
        }

        public virtual float Debit(float debitAmmount)
        {
            this.balance -= debitAmmount;
            return balance;
        }

        public virtual void DisplayAccountDetails()
        {
            Console.WriteLine(accountType);
            Console.WriteLine(accountNumber);
            Console.WriteLine(balance);
        }


    }//End of class
}
