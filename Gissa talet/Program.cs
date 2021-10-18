using System;
using System.Threading;

namespace Gissa_talet
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuChoise = "0";
            int number = 0;
            int minValue = 1;
            int maxValue = 11;
            Random numberGenerator = new Random();
            string playerName = "ingen";
            string settingsChoice = "0";
            int valueChange;

            //presentation
            Console.WriteLine("Välkommen till Gissa talet!");
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("");

            //while (menuChoise)
            while (menuChoise != "4")
            { 
                //meny
                Console.WriteLine("1. Spela Gissa talet");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Visa reglerna");
                Console.WriteLine("4. Avsluta spelet");
                Console.WriteLine("5. Inställningar");
                menuChoise = Console.ReadLine();

                //switch case
                switch (menuChoise)
                {
                    case "1":
                        //1. spela
                        //slumpa fram ett tal
                        number = numberGenerator.Next(minValue, maxValue);

                        //be spelaren gissa
                        Console.WriteLine("");
                        Console.WriteLine($"Datorn har slumpat fram ett tal mellan {minValue} och {maxValue - 1}.");
                        Console.WriteLine("Vilket tror du att det är?");
                        int playerAnswer = int.Parse(Console.ReadLine());

                        //while (playerAnswer != number)
                        while (playerAnswer != number)
                        {

                            //if playerAnswer > number
                            if (playerAnswer > number)
                            {
                                //gissade för högt
                                Console.WriteLine("Du gissade för högt, försök igen med ett lägre tal.");
                                playerAnswer = int.Parse(Console.ReadLine());
                            }

                            //else
                            else
                            {
                                //gissade för lågt
                                Console.WriteLine("Du gissade för lågt, prova igen med ett större tal.");
                                playerAnswer = int.Parse(Console.ReadLine());
                            }

                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Du gisade rätt! Talet var {number}!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");
                        Console.WriteLine("Vad heter du?");
                        playerName = Console.ReadLine();

                        break;

                    case "2":
                        //2. senaste vinnaren

                        if (playerName != "ingen")
                        { 
                            Console.WriteLine("");
                            
                            Console.WriteLine($"Den senaste vinnaren är:");
                            Thread.Sleep(1000);
                            Console.WriteLine(playerName);
                            Thread.Sleep(500);
                        }

                        else
                        {
                            Console.WriteLine("Ingen har vunnit än!");
                        }
                        break;

                    case "3":
                        //3. regler
                        Console.WriteLine("");
                        Console.WriteLine("Regler:");
                        Console.WriteLine("Datorn kommer att slumpa fram ett tal mellan 1 och 10.");
                        Console.WriteLine("Du ska försöka gissa vilket talet är.");
                        Console.WriteLine("Du kommer att få veta om du gisade för högt eller för lågt.");
                        Console.WriteLine("Lycka till!");
                        break;

                    case "4":
                        //4. avlsuta
                        Console.WriteLine("Programmet avslutas...");
                        break;

                    case "5":

                        Console.WriteLine("");
                        while (settingsChoice != "3")
                        {
                            Console.WriteLine("Vad vill du ändra på?");
                            Console.WriteLine("1. Datorns maxtal");
                            Console.WriteLine("2. Datorns mintal");
                            Console.WriteLine("3. Gå tillbaka till huvudmenyn");
                            settingsChoice = Console.ReadLine();

                            switch (settingsChoice)
                            {
                                case "1":
                                    Console.WriteLine("Vad vill du sätta som nytt maxtal?");
                                    valueChange = int.Parse(Console.ReadLine());
                                    maxValue = valueChange + 1;
                                    break;

                                case "2":
                                    Console.WriteLine("Vad vill du sätta som nytt mintal?");
                                    minValue = int.Parse(Console.ReadLine());
                                    break;
                            }
                        }

                        break;

                    default:
                        //default: ogiltigt alt.
                        Console.WriteLine("");
                        Console.WriteLine("Du valde inget giltigt alternativ.");
                        Console.WriteLine("Försök igen");
                        break;
                        
                }
                // tom rad
                Console.WriteLine("");
            }
        }
    }
}
