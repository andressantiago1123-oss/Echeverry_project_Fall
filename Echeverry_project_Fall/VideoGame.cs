using System;

namespace Echeverry_project_Fall
{
    public class VideoGame
    {
        public string GameName { get; set; }
        public double GamePrice { get; set; }

        public VideoGame()
        {
            GameName = "";
            GamePrice = 0.0;
        }

        public VideoGame(string name, double price)
        {
            GameName = name;
            GamePrice = price;
        }
    }
}