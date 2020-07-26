using System;
using System.Collections.Generic;
using System.Text;

namespace PortfolioTracker
{
    public class Actions
    {
        Portfolio portfolio = new Portfolio();

       
        public decimal TotalValue()
        {
            decimal total = 0M;
            foreach (Stock stock in portfolio.stockAddition)
            {
                total = total + (stock.Shares * stock.Price);
            }
            return total;
        }
        
        public decimal AveragePosition()
        {
            decimal averagePosition = 0M;
            foreach (Stock stock in portfolio.stockAddition)
            {
                averagePosition = averagePosition + (stock.Shares * stock.Price) / portfolio.stockAddition.Count;
            }
            return averagePosition;
        }
        public void BuyStock()
        {

            foreach (Stock stock in portfolio.stockAddition)
                Console.WriteLine($"Consider buying {stock.Ticker} when price falls to ${stock.Price - stock.Price * 0.2M} ");
        }
        public void SellStock()
        {

            foreach (Stock stock in portfolio.stockAddition)
                Console.WriteLine($"Consider selling {stock.Ticker} when price gets to ${stock.Price + stock.Price * 0.3M} ");
        }

        public void Overweight()
        {
            decimal avaragePrice = AveragePosition();

            foreach (Stock stock in portfolio.stockAddition)
            {
                if (stock.Price * stock.Shares > avaragePrice)
                {
                    Console.WriteLine($"Your position in {stock.Ticker} is overweight by ${stock.Price * stock.Shares - avaragePrice}. Consider selling a little. ");
                }
            }
        }

        public void PrintMainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine(" 1 - View Stocks");
            Console.WriteLine(" 2 - See Total Value");
            Console.WriteLine(" 3 - Price to Buy More Stock");
            Console.WriteLine(" 4 - Price to Sell Some Stock");
            Console.WriteLine(" 5 - Average Position");
            Console.WriteLine(" 6 - Which Positions are Overweight");
            Console.WriteLine(" Q - Exit");
        }
    }
}

