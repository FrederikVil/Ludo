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

        // De 2 næste bruges til at tjekke hvilken af de 2 farver der skal slå efter den første.
        public int FirstStartPos
        {
            get; set;
        }

        public int SecondStartsPos
        {
            get; set;
        }

        // De næste 2 bruger jeg til at finde ud af hvor de 2 farver står i forhold til hvem der er first og second.
        public int FirstPosition
        {
            get; set;
        }

        public int SecondPosition
        {
            get; set;
        }


    }
}
