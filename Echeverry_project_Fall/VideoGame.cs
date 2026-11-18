using System;
namespace Echeverry_project_Fall
{
    public class VideoGame
    {
        public const string XBOX_CHOICE = "Xbox";
        public const string PLAYSTATION_CHOICE = "PlayStation";
        public const string PC_CHOICE = "PC";

        public static double xboxTaxRate = 0.05;
        public static double playstationTaxRate = 0.06;
        public static double pcTaxRate = 0.08;

        public double taxRate { get; set; } 
        public string GameName { get; set; }
        public string Platform { get; set; }
        public double GamePrice { get; set; }
        public double TaxAmount { get; set; }
        public double TotalAmount { get; set; }

        public VideoGame()
        {
            GameName = "";
            Platform = "";
            GamePrice = 0.0;
            TaxAmount = 0.0;
            TotalAmount = 0.0;
        }

        public VideoGame(string name, double price, string platform)
        {
            GameName = name;
            Platform = platform;
            GamePrice = price;
            CalculateTotals();
        }


        public void CalculateTotals()
            {
            switch (Platform)
            {
                case XBOX_CHOICE:
                    taxRate = xboxTaxRate;
                    break;
                case PLAYSTATION_CHOICE:
                    taxRate = playstationTaxRate;
                    break;
                case PC_CHOICE:
                    taxRate = pcTaxRate;
                    break;
                default:
                    taxRate = xboxTaxRate;
                    break;
            }

            TaxAmount = GamePrice * taxRate;
            TotalAmount = GamePrice + TaxAmount;
            }


        public override string ToString()
        {
            return "Game Name: " + GameName + Environment.NewLine +
                "Platform: " + Platform + Environment.NewLine + 
                "Price: " + GamePrice.ToString("C") + Environment.NewLine +
                "Tax Rate: " + taxRate.ToString("P0") + Environment.NewLine +
                "Tax Amount: " + TaxAmount.ToString("C") + Environment.NewLine +
                "Total: " + TotalAmount.ToString("C");

        }
      }
    }
