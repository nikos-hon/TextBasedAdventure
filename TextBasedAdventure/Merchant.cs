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

        TextBasedAdventure.NameCallClass newNameCall = new TextBasedAdventure.NameCallClass();
        TextBasedAdventure.Mechanics mechanics = new TextBasedAdventure.Mechanics();

        public void NewMerchant(string newHeroName, int newLife, string newWeapon, string newWeaponCall, int newWeaponDMG, string newArmor, string newArmorCall, int newArmorDEF, int newPotion, int newGold, string oldSpecialItem, string newArea, string newMerchName, out string returnToArea, out string purchasedWeapon, out string purchasedWeaponCall, out int purchasedWeaponDMG, out string purchasedArmor, out string purchasedArmorCall, out int purchasedArmorDEF, out int goldAfterShop, out int potionsAfterShop, out string newSpecialItem)
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
            

            while (exitShop == false)
            {

                Console.Clear();
                mechanics.ShowLife(newLife);
                mechanics.ShowInventory(newWeapon, newWeaponDMG, newArmor, newArmorDEF, newPotion, newGold, oldSpecialItem);
                mechanics.ShowArea(newArea);


                Console.WriteLine();
                Console.WriteLine($"- Καλημέρα βάρβαρε {nameCall}, είπε ο {newMerchName}, ο έμπορος του χωριού.");
                Console.WriteLine("- Ρίξε μια ματιά στην πραμάτεια μου και πες μου αν θες να αγοράσεις κάτι.");
                Console.WriteLine();


                string item1Name = "Κοφτεροί σουγιάδες";
                string item1NameCall = "τους κοφτερούς σουγιάδες";
                int item1DMG = 5;
                int price1 = 6;

                string item2Name = "Ατσάλινη πανοπλία";
                string item2NameCall = "την ατσάλινη πανοπλία";
                int item2DEF = 4;
                int price2 = 6;

                string item3Name = "Μυστήριο κουτάκι";
                string item3NameCall = "το μυστήριο κουτάκι";
                int price3 = 6;

                int price4 = 2;


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


                if (oldSpecialItem == item3Name)
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

                    Console.Write($"[4] Φίλτρο +50 HP, ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{price4} χρυσά.");
                    Console.ResetColor();
                
                Console.WriteLine("[5] Επιστροφή στο χωριό");

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
                            purchasedArmorCall = item2NameCall;
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

                    if (purchased3 == true)
                    {

                    }

                    else
                    {
                        if (newGold >= price3)
                        {
                            oldSpecialItem = item3Name;
                            newGold = newGold - price2;
                            purchased3 = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Αγόρασες {item3NameCall}!");
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

                    if (newGold >= price3)
                    {
                        newPotion++;
                        newGold = newGold - price2;
                        purchased4 = true;
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

                else if (merchChoice == "5")
                {

                    exitShop = true;
                    purchased1 = false;
                    purchased2 = false;
                    purchased3 = false;
                    purchased4 = false;
                    purchasedWeapon = newWeapon;
                    purchasedWeaponDMG = newWeaponDMG;
                    purchasedArmor = newArmor;
                    purchasedArmorDEF = newArmorDEF;
                    goldAfterShop = newGold;
                    potionsAfterShop = newPotion;
                    newSpecialItem = oldSpecialItem;
                    purchasedWeaponCall = newWeaponCall;
                    purchasedArmorCall = newArmorCall;

                    returnToArea = "ΧΩΡΙΟ";


                }
            }
        }
    }
}
