using System;
using System.Security.Cryptography.X509Certificates;

namespace Echeverry_project_Fall
{
    public class VideoGame
    {
        private double taxRate = 0.08; 

        public string GameName { get; set; }
        public double GamePrice { get; set; }
        public double TaxAmount { get; set; }
        public double TotalAmount { get; set; }

        public VideoGame()
        {
            GameName = "";
            GamePrice = 0.0;
            TaxAmount = 0.0;
            TotalAmount = 0.0;
        }

        public VideoGame(string name, double price)
        {
            GameName = name;
            GamePrice = price;
        }

        public void CalculateTotals()
            {
                TaxAmount = GamePrice * taxRate;
                TotalAmount = GamePrice + TaxAmount;
            }

        public override string ToString()
        {
            return "Game Name: " + GameName + "\r\n" +
                "Price: " + GamePrice.ToString("C") + "\r\n" +
                "Tax Rate: " + taxRate.ToString("P0") + "\r\n" +
                "Tax Amount: " + TaxAmount.ToString("C") + "\r\n" +
                "Total: " + TotalAmount.ToString("C");

        }
      }
    }
