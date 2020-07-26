using System;
using System.Collections.Generic;
using System.Text;

namespace PortfolioTracker
{
    public class Portfolio
    {

        public List<Stock> stockAddition = new List<Stock>
        {
        new Stock("AMZN", "Amazon", 3000M, 2),
        new Stock("MSFT", "Microsoft", 200M, 3),
        new Stock("TSLA", "Tesla", 1400M, 4),
        new Stock("ZM", "Zoom", 250M, 5),
        new Stock("NVDA", "Nvidia", 400M, 6),
        };


        public void GetPortfolio()
        {
            foreach (Stock stock in stockAddition)
                Console.WriteLine($"Ticker: {stock.Ticker} | Companay Name: {stock.Name} | Purchase Price: ${stock.Price} | Shares: {stock.Shares}");
        }
    }

}





