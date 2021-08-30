using System;
namespace TextBasedAdventure
{
    public class Merchant
    {

        string name = null;
        string nameCall = null;
        string nameRef = null;
        string nameOf = null;
        string merchChoice = null;
        string returnToArea = null;

        bool purchased1 = false;
        bool purchased2 = false;
        bool purchased3 = false;
        bool purchased4 = false;
        bool purchased5 = false;

        TextBasedAdventure.NameCallClass newNameCall = new TextBasedAdventure.NameCallClass();
        TextBasedAdventure.Mechanics mechanics = new TextBasedAdventure.Mechanics();

        public void NewMerchant(string newHeroName, int newLife, string newWeapon, string newWeaponCall, int newWeaponDMG, string newArmor, string newArmorCall, int newArmorDEF, int newPotion, int newGold, string oldSpecialItem, string defaulSpecialItemQuest, string lampInput, string newArea, string newMerchName, out string returnToArea, out string purchasedWeapon, out string purchasedWeaponCall, out int purchasedWeaponDMG, out string purchasedArmor, out string purchasedArmorCall, out int purchasedArmorDEF, out int goldAfterShop, out int potionsAfterShop, out string newSpecialItem, out string lamp)
        {

            newNameCall.NameCall(newHeroName, out name, out nameCall, out nameRef, out nameOf);

            bool exitShop = false;
            returnToArea = newArea;
            purchasedWeapon = newWeapon;
            purchasedWeaponCall = newWeaponCall;
            purchasedWeaponDMG = newWeaponDMG;
            purchasedArmor = newArmor;
            purchasedArmorDEF = newArmorDEF;
            goldAfterShop = newGold;
            potionsAfterShop = newPotion;
            newSpecialItem = oldSpecialItem;
            purchasedArmorCall = newArmorCall;
            lamp = lampInput;

            while (exitShop == false)
            {

                Console.Clear();
                mechanics.ShowLife(newLife);
                mechanics.ShowInventory(newWeapon, newWeaponDMG, newArmor, newArmorDEF, newPotion, newGold, oldSpecialItem, lampInput);
                mechanics.ShowArea(newArea);

                Console.WriteLine();
                Console.WriteLine($"- Καλημέρα βάρβαρε {nameCall}, είπε ο {newMerchName}, ο έμπορος του χωριού.");
                Console.WriteLine("- Ρίξε μια ματιά στην πραμάτεια μου και πες μου αν θες να αγοράσεις κάτι.");
                Console.WriteLine();


                string item1Name = "Κοφτεροί σουγιάδες";
                string item1NameCall = "τους κοφτερούς σουγιάδες";
                int item1DMG = 10;
                int price1 = 35;

                string item2Name = "Πέτρινη πανοπλία";
                string item2NameCall = "την πέτρινη πανοπλία";
                int item2DEF = 3;
                int price2 = 50;

                string item3Name = "Τσιμπλοφάναρο";
                int price3 = 40;

                // Εντυπωσιακό αντικείμενο
                string item4Name = defaulSpecialItemQuest;
                string item4NameCall = $"το {defaulSpecialItemQuest.ToLower()}";
                int price4 = 100;

                // Potion
                int price5 = 10;


                if (newWeapon == item1Name)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"[1] {item1Name} DMG: {item1DMG}");
                    Console.ResetColor();
                }

                else
                {

                    Console.Write($"[1] {item1Name} (DMG {item1DMG}), ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{price1} χρυσά.");
                    Console.ResetColor();
                }

                if (newArmor == item2Name)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"[2] {item2Name} (DEF {item2DEF})");
                    Console.ResetColor();
                }

                else
                {
                    Console.Write($"[2] {item2Name} (DEF {item2DEF}), ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{price2} χρυσά.");
                    Console.ResetColor();
                }

                if (lampInput == item3Name)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"[3] {item3Name}");
                    Console.ResetColor();
                }

                else
                {
                    Console.Write($"[3] {item3Name}, ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{price3} χρυσά.");
                    Console.ResetColor();
                }



                if (oldSpecialItem == item4Name || oldSpecialItem == "itemQuestComplete")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"[4] {item4Name}");
                    Console.ResetColor();
                }

                else
                {
                    Console.Write($"[4] {item4Name}, ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{price4} χρυσά.");
                    Console.ResetColor();
                }

                    Console.Write($"[5] Φίλτρο +50 HP, ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{price5} χρυσά.");
                    Console.ResetColor();
                
                Console.WriteLine("[6] Επιστροφή στο χωριό");

                Console.WriteLine();

                Console.WriteLine();
                merchChoice = Console.ReadLine();
                Console.WriteLine();

                if (merchChoice == "1")
                {
                    if (newWeapon == item1Name)
                    {

                    }

                    else
                    {
                        if (newGold >= price1)
                        {
                            newWeapon = item1Name;
                            newGold = newGold - price1;
                            newWeaponDMG = item1DMG;
                            newWeaponCall = item1NameCall;
                            purchased1 = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Αγόρασες {item1NameCall}!");
                            Console.ResetColor();
                            Console.WriteLine();
                            mechanics.PressAnyKey();

                        }

                        else
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Δεν έχεις αρκετό χρυσό.");
                            Console.ResetColor();
                            Console.WriteLine();
                            mechanics.PressAnyKey();
                        }
                    }
                }

                else if (merchChoice == "2")
                {

                    if (newArmor == item2Name)
                    {

                    }

                    else
                    {
                        if (newGold >= price2)
                        {
                            newArmor = item2Name;
                            newGold = newGold - price2;
                            newArmorDEF = item2DEF;
                            newArmorCall = item2NameCall;
                            purchased2 = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Αγόρασες {item2NameCall}!");
                            Console.ResetColor();
                            mechanics.PressAnyKey();

                        }

                        else
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Δεν έχεις αρκετό χρυσό.");
                            Console.ResetColor();
                            Console.WriteLine();
                            mechanics.PressAnyKey();
                        }
                    }
                }

                else if (merchChoice == "3")
                {

                    if (lampInput == item3Name)
                    {

                    }

                    else
                    {
                        if (newGold >= price3)
                        {
                            newGold = newGold - price3;
                            lampInput = item3Name;
                            purchased3 = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Αγόρασες το {item3Name.ToLower()}!");
                            Console.ResetColor();
                            mechanics.PressAnyKey();

                        }

                        else
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Δεν έχεις αρκετό χρυσό.");
                            Console.ResetColor();
                            Console.WriteLine();
                            mechanics.PressAnyKey();
                        }
                    }
                }

                else if (merchChoice == "4")
                {

                    if (oldSpecialItem == item4Name || oldSpecialItem == "itemQuestComplete")
                    {

                    }

                    else
                    {
                        if (newGold >= price4)
                        {
                            oldSpecialItem = item4Name;
                            newGold = newGold - price4;
                            purchased4 = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Αγόρασες {item4NameCall}!");
                            Console.ResetColor();
                            mechanics.PressAnyKey();
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Δεν έχεις αρκετό χρυσό.");
                            Console.ResetColor();
                            Console.WriteLine();
                            mechanics.PressAnyKey();
                        }
                    }
                }

                else if (merchChoice == "5")
                {

                    if (newGold >= price5)
                    {
                        newPotion++;
                        newGold = newGold - price5;
                        purchased5 = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Αγόρασες ένα φίλτρο!");
                        Console.ResetColor();
                        mechanics.PressAnyKey();
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Δεν έχεις αρκετό χρυσό.");
                        Console.ResetColor();
                        Console.WriteLine();
                        mechanics.PressAnyKey();
                    }

                }

                else if (merchChoice == "6")
                {

                    exitShop = true;
                    purchased1 = false;
                    purchased2 = false;
                    purchased3 = false;
                    purchased4 = false;
                    purchased5 = false;
                    purchasedWeapon = newWeapon;
                    purchasedWeaponDMG = newWeaponDMG;
                    purchasedWeaponCall = newWeaponCall;

                    purchasedArmor = newArmor;
                    purchasedArmorDEF = newArmorDEF;
                    purchasedArmorCall = newArmorCall;
                    goldAfterShop = newGold;
                    potionsAfterShop = newPotion;
                    newSpecialItem = oldSpecialItem;
                    lamp = lampInput;
                    returnToArea = "                            ΧΩΡΙΟ";

                }
            }
        }
    }
}
