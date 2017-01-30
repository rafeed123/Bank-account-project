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
            Account mainAccount = new Account();
            Checking asterickFree = new Checking();
            Savings premierSavings = new Savings();
            Reserve overDraft = new Reserve();

            mainAccount.Intro();

           

            //While loop to run program
            int i = 1;
            while(i==1)
            {

            
            
            Console.WriteLine("Enter an account you would like to access /Checking/Savings/Reserve/ ");
            string userInput = Console.ReadLine();
            userInput.ToLower();
            if (userInput.ToLower() == "checking")
            {
                asterickFree.DisplayAccountDetails();
                Console.WriteLine();
                Console.WriteLine("Enter withdrawl to WITHDRAWL enter deposit to DEPOSIT enter exit to EXIT");
                string transaction = Console.ReadLine();
                transaction.ToLower();
                if (transaction.ToLower() == "deposit")
                {
                    asterickFree.Credit(.00f);
                    asterickFree.DisplayAccountDetails();
                }
                else if (transaction.ToLower() == "withdrawl")
                {
                    asterickFree.Debit(.00f);
                    asterickFree.DisplayAccountDetails();
                }
                else if (transaction.ToLower() == "exit")
                {
                        Environment.Exit(0);

                }


            }
            else if (userInput.ToLower() == "savings")
            {
                premierSavings.DisplayAccountDetails();
                Console.WriteLine();
                Console.WriteLine("Enter withdrawl to WITHDRAWL enter deposit to DEPOSIT enter exit to EXIT");
                string transaction = Console.ReadLine();
                transaction.ToLower();
                if (transaction.ToLower() == "deposit")
                {
                    premierSavings.Credit(.00f);
                    premierSavings.DisplayAccountDetails();
                }
                else if (transaction.ToLower() == "withdrawl")
                {
                    premierSavings.Debit(.00f);
                    premierSavings.DisplayAccountDetails();
                }
                else if (transaction.ToLower() == "exit")
                {
                    Environment.Exit(0);

                }
            }
            else if (userInput.ToLower() == "reserve")
            {
                overDraft.DisplayAccountDetails();
                Console.WriteLine();
                Console.WriteLine("Enter withdrawl to WITHDRAWL enter deposit to DEPOSIT enter exit to EXIT");
                string transaction = Console.ReadLine();
                transaction.ToLower();
                if (transaction.ToLower() == "deposit")
                {
                    overDraft.Credit(.00f);
                    overDraft.DisplayAccountDetails();
                }
                else if (transaction.ToLower() == "withdrawl")
                {
                    overDraft.Debit(.00f);
                    overDraft.DisplayAccountDetails();
                }
                else if (transaction.ToLower() == "exit")
                {
                        Environment.Exit(0);

                }
            }
            else
            {
                Console.WriteLine("Invalid input try again");
            }


            }//End of while loop




        }//End of Program
    }
}
