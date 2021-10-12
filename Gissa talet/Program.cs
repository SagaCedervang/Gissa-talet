using System;

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
            string playerName = "ingen har vunnit än";

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

                        Console.WriteLine($"Du gisade rätt! Talet var {number}!");
                        Console.WriteLine("Vad heter du?");


                        break;

                    case "2":
                        //2. senaste vinnaren
                        Console.WriteLine(playerName);
                        break;

                    case "3":
                        //3. regler
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

                    default:
                        //default: ogiltigt alt.
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
