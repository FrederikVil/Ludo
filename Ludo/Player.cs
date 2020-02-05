using System;
using System.Collections.Generic;
using System.Text;

namespace Ludo
{
    class Player
    {
        // De forskellige farver på ludo brikkerne
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


        // Asigner farve til hver spiller
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

        // First og second bruges til at tjekke hvem der skal slå først. Den der slår først bliver assigned til first osv.
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
