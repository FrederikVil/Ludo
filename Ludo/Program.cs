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
                int firstTurnRoll = d.Roll();
                
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
                
                // If statement der tjekker hvem der går først. Den der går først bliver assigned til First og den anden til Second.
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
                Board startPos = new Board();
                Player firstStartPos = new Player();
                Player secondStartPos = new Player();
                Player firstPosition = new Player();
                Player secondPosition = new Player();
                int redPosition = startPos.Ludoboard[0] + firstTurnRoll;
                int yellowPosition = startPos.Ludoboard[14] + firstTurnRoll;
                int game = startPos.Ludoboard.Length;
                
                
                // If statement i forhold til hvilken farve blev assigned til First og Second.
                // Efter den kører første tur igennem med First farven, bliver den anden farve assigned til SecondStartPos
                // Og First farven bliver assigned til FirstStartPos så mit loop kan se hvilken rækkefølge den skal slå i.
                if (First.Color == playerOne.Color)
                {
                    Console.WriteLine($"{First.Color} starts on field {startPos.RedStartPos} and rolls a {firstTurnRoll}. " +
                  $"{First.Color} is now on field {redPosition}");
                    // RedStartPos = startPos.Ludoboard[0] + firstTurnRoll;
                    startPos.RedStartPos = redPosition; 
                    // Rød bliver nu bare First oog starter på 0 (Rød startposition)
                    firstStartPos.FirstStartPos = startPos.RedStartPos;
                    // Gul bliver nu Second og starter på 14 (gul startposition)
                    secondStartPos.SecondStartsPos = startPos.Ludoboard[14];
                                
                }
                else if (First.Color == playerTwo.Color)
                {
                    Console.WriteLine($"{First.Color} starts on field {startPos.YellowStartPos} and rolls a {firstTurnRoll}. " +
                  $"{First.Color} is now on field {yellowPosition}");
                    // Det samme som ovenover, bare omvendt i forhold til farverne.
                    startPos.YellowStartPos = yellowPosition;
                    firstStartPos.FirstStartPos = startPos.YellowStartPos;
                    secondStartPos.SecondStartsPos = startPos.Ludoboard[0];

                }
                Console.WriteLine("Press enter to roll");
                Console.ReadLine();
                
                // Nu har jeg First og Second placerett rigtigt, og kører bare et loop der starter med Second 
                // da First lige har taget første tur
                for (int i = 0; i < 30; i++)
                {
                    int rollTurn = d.Roll();
                    Console.WriteLine($"{Second.Color} is on field {secondStartPos.SecondStartsPos} and rolls a {rollTurn}. " +
                  $"{Second.Color} is now on field {secondPosition.SecondPosition = secondStartPos.SecondStartsPos+=rollTurn}");
                    secondStartPos.SecondStartsPos = secondPosition.SecondPosition;

                    if (secondStartPos.SecondStartsPos >= game)
                    {
                        Console.WriteLine("Second wins");
                        break;
                    }
                }

            }
            // Exeption: mere end 4 spillere.
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
