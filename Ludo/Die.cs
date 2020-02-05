using System;
using System.Collections.Generic;
using System.Text;

namespace Ludo
{
    class Die
    {
        // Jeg laver kun en random, ellers får jeg det samme tal hvver gang jeg kalder den.
        Random rand = new Random();

        // Med 2 rolls, får jeg et forskelligt tal til hvert roll.
        public int RollRed()
        {           
            return rand.Next(1, 7);
        }   
        
        public int RollYellow()
        {           
            return rand.Next(1, 7);
        }   
        
        public int RollASix()
        {           
            return rand.Next(1, 7);
        }      
        
        public int RollTurn()
        {           
            return rand.Next(1, 7);
        }
    }
}
