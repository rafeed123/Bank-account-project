using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Checking asterickFree = new Checking();
            Savings premierSavings = new Savings();
            Reserve overDraft = new Reserve();

            Console.WriteLine("Enter an account you would like to access /Checking/Savings/Reserve/ ");
            string userInput = Console.ReadLine();
            userInput.ToLower();
            if (userInput == "checking")
            {
                asterickFree.DisplayAccountDetails();
                Console.WriteLine("Enter withdralw to WITHDRALW enter deposit to DEPOSIT");
                string transaction = Console.ReadLine();
                transaction.ToLower();
                if (transaction == "deposit")
                {
                    asterickFree.Credit(.00f);
                    asterickFree.DisplayAccountDetails();
                }
                else if (transaction == "withdrawl")
                {
                    asterickFree.Debit(.00f);
                    asterickFree.DisplayAccountDetails();
                }
                else if (transaction == "exit")
                {
                    Main(args);

                }


            }
            else if (userInput == "savings")
            {
                premierSavings.DisplayAccountDetails();
                Console.WriteLine("Enter withdralw to WITHDRALW enter deposit to DEPOSIT");
                string transaction = Console.ReadLine();
                transaction.ToLower();
                if (transaction == "deposit")
                {
                    premierSavings.Credit(.00f);
                    premierSavings.DisplayAccountDetails();
                }
                else if (transaction == "withdrawl")
                {
                    premierSavings.Debit(.00f);
                    premierSavings.DisplayAccountDetails();
                }
                else if (transaction == "exit")
                {
                    Main(args);

                }
            }
            else if (userInput == "reserve")
            {
                overDraft.DisplayAccountDetails();
                Console.WriteLine("Enter withdralw to WITHDRALW enter deposit to DEPOSIT");
                string transaction = Console.ReadLine();
                transaction.ToLower();
                if (transaction == "deposit")
                {
                    overDraft.Credit(.00f);
                    overDraft.DisplayAccountDetails();
                }
                else if (transaction == "withdrawl")
                {
                    overDraft.Debit(.00f);
                    overDraft.DisplayAccountDetails();
                }
                else if (transaction == "exit")
                {
                    Main(args);

                }
            }
            else
            {
                Console.WriteLine("Invalid input try again");
            }







        }//End of Program
    }
}
