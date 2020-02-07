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
                Console.WriteLine($"{playerOne.Color} is playing (field 0-62)");
                Console.WriteLine($"{playerTwo.Color} is playing (field 14-14)");
                Console.WriteLine("The board goes from field 0-62. The first to complete their lap wins!");

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
                int gameRed = startPos.Ludoboard.Length;
                int gameYellow = startPos.Ludoboard[14];
                
                
                // If statement i forhold til hvilken farve blev assigned til First og Second.
                // Efter den kører første tur igennem med First farven, bliver den anden farve assigned til SecondStartPos
                // Og First farven bliver assigned til FirstStartPos så mit loop kan se hvilken rækkefølge den skal slå i.
                if (First.Color == playerOne.Color)
                {
                    Console.WriteLine($"{First.Color} starts on field {startPos.RedStartPos} and rolls a {firstTurnRoll}. " +
                  $"{First.Color} is now on field {redPosition}");
                    // RedStartPos = startPos.Ludoboard[0] + firstTurnRoll;
                    startPos.RedStartPos = redPosition; 
                    // Rød bliver nu bare First og starter på 0 (Rød startposition)
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
                
                // Nu har jeg First og Second placeret rigtigt, og kører bare et loop der starter med Second 
                // da First lige har taget første tur
                for (int i = 0; i < 30; i++)
                {
                    int rollTurn = d.Roll();

                    // Jeg sørger for at den siger Second.Color "starts on field x" og alle andre gange "is on field".
                    if (i < 1)
                    {    
                        Console.WriteLine($"{Second.Color} starts on field {secondStartPos.SecondStartsPos} and rolls a {rollTurn}. " +
                      $"{Second.Color} is now on field {secondPosition.SecondPosition = secondStartPos.SecondStartsPos += rollTurn}. Press enter to roll.");
                        secondStartPos.SecondStartsPos = secondPosition.SecondPosition;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"{Second.Color} is on field {secondStartPos.SecondStartsPos} and rolls a {rollTurn}. " +
                      $"{Second.Color} is now on field {secondPosition.SecondPosition = secondStartPos.SecondStartsPos += rollTurn}. Press enter to roll.");
                        secondStartPos.SecondStartsPos = secondPosition.SecondPosition;
                        Console.ReadLine();
                    }

                    // Hvis rød er Second, så skal rød vinde hvis den rammer 62 eller derover.
                    if (Second.Color == playerOne.Color )
                    {
                        if (secondPosition.SecondPosition >= gameRed)
                        {
                            Console.WriteLine($"{Second.Color} landed on or passed field 62 and is now in goal");
                            break;
                        }
                    }
                    // Hvis gul er Second, skal startpositionen ændres til positionen - arrayets længde hvis den går over arrayets længde (62)
                    // (for eksempel 66-62 = 4. Så den næste gang loopet kører starter den på 4).
                    else if (Second.Color == playerTwo.Color)
                    {
                        if (secondPosition.SecondPosition >= startPos.Ludoboard.Length)
                        {
                            secondStartPos.SecondStartsPos = secondPosition.SecondPosition - startPos.Ludoboard.Length;                          
                        }
                        // Hvis startpositionen er større eller lige med 14 og det ikke er en af de første gange loopet kører (den starter på 14) 
                        // og positionen er mindre end 20 skal gul vinde.
                        if (secondStartPos.SecondStartsPos >= gameYellow && i > 5 && secondPosition.SecondPosition < 20)
                        {
                            Console.WriteLine($"{Second.Color} landed on or passed field 14 and is now in goal");
                            break;
                        }

                    }

                   
                    Console.WriteLine($"{First.Color} is on field {firstStartPos.FirstStartPos} and rolls a {rollTurn}. " +
                  $"{First.Color} is now on field {firstPosition.FirstPosition = firstStartPos.FirstStartPos += rollTurn}. Press enter to roll.");
                    firstStartPos.FirstStartPos = firstPosition.FirstPosition;
                    Console.ReadLine();

                    // Det samme som ovenover, bare med First i stedet for Second.
                    if (First.Color == playerOne.Color )
                    {
                        if (firstPosition.FirstPosition >= gameRed)
                        {
                            Console.WriteLine($"{First.Color} landed on or passed field 62 and is now in goal");
                            break;
                        }
                    }
                    else if (First.Color == playerTwo.Color )
                    {
                        if (firstPosition.FirstPosition >= startPos.Ludoboard.Length)
                        {
                            firstStartPos.FirstStartPos = firstPosition.FirstPosition - startPos.Ludoboard.Length;
                           
                        }
                        if (firstStartPos.FirstStartPos >= gameYellow && i > 5 && firstPosition.FirstPosition < 20)
                        {
                            Console.WriteLine($"{First.Color} landed on or passed field 14 and is now in goal");
                            break;
                        }
                    }

                }
                Console.WriteLine("End of game");
            }
            // Exeption: mere end 4 spillere.
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
                      
        }
    }
}

