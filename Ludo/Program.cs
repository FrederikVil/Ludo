using System;

namespace Ludo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Jeg laver en ny variabel til hver roll, så jeg ikke får det samme tal hver gang.
                Die d = new Die();
                int rollRed = d.Roll();
                int rollYellow = d.Roll();
                int rollASix = d.Roll();
                int rollTurn = d.Roll();
                
                // Jeg laver spillerne.
                Player playerOne = new Player();
                Player playerTwo = new Player();
                Console.WriteLine($"{playerOne.Color} is playing");
                Console.WriteLine($"{playerTwo.Color} is playing");

                // Kaster terningerne
                Console.WriteLine("\nRoll dice to see who goes first. Press enter to roll!");
                Console.ReadLine();
                Console.WriteLine($"{playerOne.Color} rolled: {rollRed}");
                Console.WriteLine($"{playerTwo.Color} rolled: {rollYellow}");

                Player First = new Player();
                Player Second = new Player();
                
                // If statement der tjekker hvem der går først. Den der går først bliver assigned til First.
                if (rollRed > rollYellow)
                {
                    Console.WriteLine("Red goes first. Press enter to roll the dice!");
                    First = playerOne;
                    Second = playerTwo;
                }
                else if (rollRed < rollYellow)
                {
                    Console.WriteLine("Yellow goes first. Press enter to roll the dice!");
                    First = playerTwo;
                    Second = playerOne;
                }
                // Mulig udvidelse: Slå om hvis samme tal bliver slået.
                else if (rollRed == rollYellow)
                {
                    Console.WriteLine("Dice rolled the same. Red has priority and goes first. Press enter to roll the dice!");
                    First = playerOne;
                    Second = playerTwo;
                }

                Console.ReadLine();
                Board ludoBoard = new Board();
                
                // Den tjekker hvem der er først, og så skriver den feltet man starter på, og hvad man slår, samt hvor man 
                // står i arrayet.
                if (First.Color == playerOne.Color)
                {
                    Console.WriteLine($"{First.Color} starts on field {ludoBoard.RedStartPos} and rolls a {rollTurn}. " +
                  $"{First.Color} is now on field {ludoBoard.RedStartPos + rollTurn}");
                }
                else if (First.Color == playerTwo.Color)
                {
                    Console.WriteLine($"{First.Color} starts on field {ludoBoard.YellowStartPos} and rolls a {rollTurn}. " +
                  $"{First.Color} is now on field {ludoBoard.YellowStartPos + rollTurn}");
                }
              

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
                      
        }
    }
}

/*
 if (rollRed > rollYellow)
                {
                    Console.WriteLine("Red goes first!");
                }
                else if (rollRed < rollYellow)
                {
                    Console.WriteLine("Yellow goes first!");
                }
                else
                {
                  
                             
                }
*/

/*
Console.WriteLine("\nRoll a 6 to get out of base: Press enter to roll");
Console.ReadLine();
Console.WriteLine(rollASix);

if (rollASix == 6)
{
// Start red turn
}
else if (rollASix != 6)
{
// Yellow's turn to roll
}
*/
