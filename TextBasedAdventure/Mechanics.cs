using System;
using System.Linq;


namespace TextBasedAdventure
{
    public class Mechanics
    {

        int newLife = 0;
        int randomPuzzle = 0;
        string puzzleAnswer = null;
        string puzzleAnswerInput = null;

        int digit1 = 0;
        int digit2 = 0;
        int digit3 = 0;
        int digit4 = 0;
        int digit5 = 0;
        int digit6 = 0;
        int digit7 = 0;
        int digit8 = 0;
        int digit9 = 0;
        int digit0 = 0;


        // Νέο Ζάρι και εμφάνιση αποπτελέσματος

        public int RollDice(int max)
        {
            Random diceResult = new Random();
            int rolledDice = diceResult.Next(1, max);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("[Πάτα ένα πλήκτρο για να ρίξεις το ζάρι...]");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[Ζάρι 1-{max}]: {rolledDice}");
            Console.ResetColor();

            return rolledDice;
        }

        // Νέο Ζάρι χωρίς μήνυμα αναμονής

        public int RollDiceNoWait(int max)
        {
            Random diceResult = new Random();
            int rolledDice = diceResult.Next(1, max);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[Ζάρι 1-{max}]: {rolledDice}");
            Console.ResetColor();

            return rolledDice;
        }

        // Νέο Ζάρι χωρίς καθόλου μήνυμα

        public int RollDiceMute(int max)
        {
            Random diceResult = new Random();
            int rolledDice = diceResult.Next(1, max);
            return rolledDice;
        }


        // Αυξομείωση και εμφάνιση ζωής

        public int ChangeLife(int prevLife, int multiplier, string hitOrHeal, int dice)
        {

            if (hitOrHeal == "hit")
            {
                newLife = prevLife - (multiplier * dice);
            }

            else if (hitOrHeal == "heal")
            {
                newLife = prevLife + (multiplier * dice);

                if (newLife > 100)
                {
                    newLife = 100;
                }

            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"[Ζωή 0-100]: {newLife}");
            Console.ResetColor();

            return newLife;
        }

        // Εμφάνιση ζωής

        public void ShowLife(int life)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"[Ζωή 0-100]: {life}");
            Console.ResetColor();
        }


        // Εμφάνιση inventory

        public void ShowInventory(string weapon, int weaponDMG, string armor, int armorDEF, int potion, int gold, string specialObject, string lamp)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"[Όπλο]: {weapon} DMG: {weaponDMG} / [Πανοπλία]: {armor} DEF: {armorDEF}");

            Console.Write($"[Φίλτρα]: {potion} / [Χρυσός]: {gold}");

            if (lamp == "Τσιμπλοφάναρο")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($" / ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"[{lamp}]");

            }

            if (specialObject != null && specialObject != "itemQuestComplete")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($" / ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"[{specialObject}]");
            }

            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
        }

        // Εμφάνιση τοποθεσίας

        public void ShowArea(string currentArea)
        {
            Console.WriteLine($"{currentArea}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
        }

        // Πάτα ένα πλήκτρο για συνέχεια

        public void PressAnyKey()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("[Πάτα ένα πλήκτρο για να συνεχίσεις...]");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine();
        }


        // Δημιουργία γρίφου

        public bool newPuzzle(string devMode)
        {
            // Ανακατεύω τους αριθμούς
            int[] digits = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Random random = new Random();
            digits = digits.OrderBy(x => random.Next()).ToArray();
            foreach (var i in digits)

            digit1 = digits[0];
            digit2 = digits[1];
            digit3 = digits[2];
            digit4 = digits[3];
            digit5 = digits[4];
            digit6 = digits[5];
            digit7 = digits[6];
            digit8 = digits[7];
            digit9 = digits[8];
            digit0 = digits[9];

            randomPuzzle = RollDiceMute(3);

            switch (randomPuzzle)
            {
                // Γρίφος 1
                case 1:
                    Console.WriteLine($"{digit1}{digit3}{digit5} - Σωστοί αριθμοί, μόνο ένας στη σωστή θέση.");
                    Console.WriteLine($"{digit1}{digit2}{digit3} - Δύο σωστοί αριθμοί, αλλά σε λάθος θέση.");
                    Console.WriteLine($"{digit3}{digit6}{digit2} - Ένας σωστός αριθμός, στη σωστή θέση.");
                    Console.WriteLine($"{digit2}{digit4}{digit1} - Ένας σωστός αριθμός, σε λάθος θέση.");
                    Console.WriteLine();
                    Console.WriteLine("Ποιός είναι ο σωστός αριθμός;");

                    puzzleAnswer = $"{digit3}{digit1}{digit5}";

                    if (devMode == "2" || devMode == "3")
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Dev mode - απάντηση: {puzzleAnswer}");
                        Console.ResetColor();
                    }

                    Console.WriteLine();
                    puzzleAnswerInput = Console.ReadLine();

                    

                    if (puzzleAnswerInput == puzzleAnswer)
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }

                    break;

                // Γρίφος 2
                case 2:
                    Console.WriteLine($"{digit2}{digit1}{digit6} - Ένας σωστός αριθμός, στη σωστή θέση.");
                    Console.WriteLine($"{digit6}{digit5}{digit2} - Δύο σωστοί αριθμοί, αλλά σε λάθος θέση.");
                    Console.WriteLine($"{digit6}{digit3}{digit1} - Τίποτα δεν είναι σωστό.");
                    Console.WriteLine($"{digit3}{digit5}{digit9} - Δύο σωστοί αριθμοί, αλλά σε λάθος θέση.");
                    Console.WriteLine();
                    Console.WriteLine("Ποιός είναι ο σωστός αριθμός;");

                    puzzleAnswer = $"{digit2}{digit9}{digit5}";

                    if (devMode == "2" || devMode == "3")
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Dev mode - απάντηση: {puzzleAnswer}");
                        Console.ResetColor();
                    }


                    Console.WriteLine();
                    puzzleAnswerInput = Console.ReadLine();

                   

                    if (puzzleAnswerInput == puzzleAnswer)
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                    break;


                // Γρίφος 1
                case 3:
                    Console.WriteLine($"{digit3}{digit4}{digit2} - Ένας σωστός αριθμός, στη σωστή θέση.");
                    Console.WriteLine($"{digit4}{digit7}{digit3} - Τίποτα δεν είναι σωστό.");
                    Console.WriteLine($"{digit1}{digit4}{digit6} - Ένας σωστός αριθμός, σε λάθος θέση.");
                    Console.WriteLine($"{digit0}{digit6}{digit9} - Ένας σωστός αριθμός, σε λάθος θέση.");
                    Console.WriteLine($"{digit8}{digit7}{digit6} - Δύο σωστοί αριθμοί, αλλά σε λάθος θέση.");
                    Console.WriteLine();
                    Console.WriteLine("Ποιός είναι ο σωστός αριθμός;");

                    puzzleAnswer = $"{digit2}{digit9}{digit5}";

                    if (devMode == "2" || devMode == "3")
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Dev mode - απάντηση: {puzzleAnswer}");
                        Console.ResetColor();
                    }



                    Console.WriteLine();
                    puzzleAnswerInput = Console.ReadLine();

                    

                    if (puzzleAnswerInput == puzzleAnswer)
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }

                    break;



                default:
                    return false;
                    break;


            }





        }




    }
}
