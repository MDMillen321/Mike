using System;
using System.Collections.Generic;
using System.Text;

namespace PortfolioTracker
{
    public class Stock
    {
        public string Ticker { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Shares { get; set; }

        public Stock(string ticker, string name, decimal price, int shares)
        {
            Ticker = ticker;
            Name = name;
            Price = price;
            Shares = shares;

        }
    }
}
