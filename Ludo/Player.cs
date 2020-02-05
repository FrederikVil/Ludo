using System;
using System.Collections.Generic;
using System.Text;

namespace Ludo
{
    class Player
    {
        private static int PlayerCount;
        public enum Colors
        {
            Red,
            Yellow,
            Green,
            Blue
        }

        public Colors Color
        {
            get;set;
        }


        public Player()
        {
            PlayerCount++;
            switch (PlayerCount)
            {
                case 1:
                    Color = Colors.Red;
                    break;
                case 2:
                    Color = Colors.Yellow;
                    break;

                case 5:
                    throw new Exception("Too many players");
                    
            }
        }

        public string First
        {
            get; set;
        }

        public string Second
        {
            get; set;
        }
    }
}
