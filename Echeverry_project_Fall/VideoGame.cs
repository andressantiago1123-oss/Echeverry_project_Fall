using System;
using System.Security.Cryptography.X509Certificates;

namespace Echeverry_project_Fall
{
    public class VideoGame
    {
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
                TaxAmount = GamePrice * 0.08;
                TotalAmount = GamePrice + TaxAmount;
            }

        public override string ToString()
        {
            return "Game: " + GameName +
                " | Price: " + GamePrice.ToString("C") +
                " | Tax: " + TaxAmount.ToString("C") +
                " | Total: " + TotalAmount.ToString("C");

        }
      }
    }
