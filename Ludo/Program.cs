using System;

namespace Ludo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Die d = new Die();
                int rollRed = d.RollRed();
                int rollYellow = d.RollRed();
                int rollASix = d.RollRed();
                int rollTurn = d.RollRed();
              
                Player playerOne = new Player();
                Player playerTwo = new Player();
                Console.WriteLine($"{playerOne.Color} is playing");
                Console.WriteLine($"{playerTwo.Color} is playing");

                Console.WriteLine("\nRoll dice to see who goes first\n");
                Console.WriteLine($"{playerOne.Color} rolled: {rollRed}");
                Console.WriteLine($"{playerTwo.Color} rolled: {rollYellow}");

                Player First = new Player();
                Player Second = new Player();
                

                if (rollRed > rollYellow)
                {
                    Console.WriteLine("Red goes first!");
                    First = playerOne;
                    Second = playerTwo;
                }
                else if (rollRed < rollYellow)
                {
                    Console.WriteLine("Yellow goes first!");
                    First = playerTwo;
                    Second = playerOne;
                }
                else if (rollRed == rollYellow)
                {
                    Console.WriteLine("Dice rolled the same. Red goes first\n");
                    First = playerOne;
                    Second = playerTwo;
                }

                Board ludoBoard = new Board();
                
                if (First.Color == playerOne.Color)
                {
                    Console.WriteLine($"{First.Color} is on field {ludoBoard.RedStartPos} and rolls a {rollTurn}. " +
                  $"{First.Color} is now on field {ludoBoard.RedStartPos + rollTurn}");
                }
                else if (First.Color == playerTwo.Color)
                {
                    Console.WriteLine($"{First.Color} is on field {ludoBoard.YellowStartPos} and rolls a {rollTurn}. " +
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
