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
