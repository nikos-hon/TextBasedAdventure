using System;
namespace TextBasedAdventure

{
    public class Mechanics
    {


        int newLife = 0;

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

        public void ShowInventory(string weapon, int weaponDMG, string armor, int armorDEF, int potion, int gold, string specialObject)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"[Όπλο]: {weapon} DMG: {weaponDMG} / [Πανοπλία]: {armor} DEF: {armorDEF}");



            if (specialObject != null)
            {

                Console.Write($"[Φίλτρα]: {potion} / [Χρυσός]: {gold} / ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"[{specialObject}]");
            }

            else
            {
                Console.WriteLine($"[Φίλτρα]: {potion} / [Χρυσός]: {gold}");
            }




            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
        }

        // Εμφάνιση τοποθεσίας

        public void ShowArea(string currentArea)
        {
            Console.WriteLine($"                        {currentArea}                                    ");
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


        
    }
}
