using System;
using System.Collections.Generic;
using System.Text;

namespace PortfolioTracker
{
    public class DisplayMenu
    {
        Portfolio portfolio = new Portfolio();
        Actions action = new Actions();


        public void Display()
        {


            Console.WriteLine("Welcome to the stock tracker!");
            while (true)
            {
                Console.WriteLine();
                action.PrintMainMenu();
                Console.WriteLine("Please choose what you would like to do");
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    portfolio.GetPortfolio();
                }

                else if (userInput == "2")
                {
                    Console.WriteLine($"Your portfolio is currently worth ${action.TotalValue()}");
                }

                else if (userInput == "3")
                {
                    action.BuyStock();

                }
                else if (userInput == "4")
                {
                    action.SellStock();

                }
                else if (userInput == "5")
                {
                    Console.WriteLine($"Your average position is currently worth ${action.AveragePosition()}");

                }
                else if (userInput == "6")
                {
                    action.Overweight();

                }
                else if (userInput == "Q".ToLower())
                {
                    break;
                }


            }
        }
    }
}















