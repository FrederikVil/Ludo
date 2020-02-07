using System;
using System.Collections.Generic;
using System.Text;

namespace Ludo
{
    class Die
    {
        
        Random rand = new Random();

        // Jeg laver et roll, og kalder den flere gange.
        public int Roll()
        {           
            return rand.Next(1, 7);
        }   
        
    }
}
