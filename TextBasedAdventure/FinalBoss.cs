using System;
namespace TextBasedAdventure
{
    public class FinalBoss
    {

        TextBasedAdventure.Mechanics mechanics = new TextBasedAdventure.Mechanics();
        TextBasedAdventure.NameCallClass newNameCall = new TextBasedAdventure.NameCallClass();
        TextBasedAdventure.Battle battle = new TextBasedAdventure.Battle();
        TextBasedAdventure.Art art = new TextBasedAdventure.Art();

        public void newBoss(string heroNameInput, string oldWiseNameInput, int life, string weapon, string weaponCall, int weaponDMG, string armor, string armorCall, int armorDEF, int potion, int gold, string specialItemInput, string specialItemQuest, string lamp, string area, string bossNameInput, bool riddleSolvedInput, string devMode, out string returnToArea, out string specialItem, out string newWeapon, out string newWeaponCall, out int newWeaponDMG, out bool riddleSolved)
        {

            newNameCall.NameCall(heroNameInput, out string heroName, out string heroNameCall, out string heroNameRef, out string heroNameOf);
            newNameCall.NameCall(oldWiseNameInput, out string oldWiseName, out string oldWiseNameCall, out string oldWiseNameRef, out string oldWiseNameOf);
            newNameCall.NameCall(bossNameInput, out string bossName, out string bossNameCall, out string bossNnameRef, out string bossNameOf);

            bool exitCastle = false;
            string dungeonChoice = null;
            string confirmChoice = null;
            string riddleAnswer = null;
            string bribeWise = null;

            specialItem = specialItemInput;
            riddleSolved = riddleSolvedInput;
            int wrongRiddleCounter = 0;
            newWeapon = weapon;
            newWeaponCall = weaponCall;
            newWeaponDMG = weaponDMG;
            returnToArea = null;

            while (exitCastle == false)
            {

                Console.Clear();

                mechanics.ShowLife(life);
                mechanics.ShowInventory(weapon, weaponDMG, armor, armorDEF, potion, gold, specialItem, lamp);
                mechanics.ShowArea(area);

                Console.WriteLine();
                Console.WriteLine($"Στην είσοδο του κάστρου στέκεται ο γέρος-σοφός {oldWiseName}.");
                Console.WriteLine();
                Console.WriteLine($"- Γεια σου και πάλι βάρβαρε {heroNameCall}. Για να συνεχίσεις στον Μεγάλο Κακό, υπάρχουν δύο προϋποθέσεις που δεν έχουν κανένα νόημα. Θα πρέπει να με εντυπωσιάσεις με ένα ξεχωριστό αντικείμενο, και θα πρέπει να λύσεις έναν γρίφο που θα σου πω.");
                Console.WriteLine();

                if (specialItemInput != null && specialItemInput != "itemQuestComplete")
                {
                    Console.Write($"[1] Δείξε στον γέρο-σοφό {oldWiseNameRef} το ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{specialItem.ToLower()}.");
                    Console.ResetColor();
                }

                else if (specialItemInput == "itemQuestComplete")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"[-] Ο γέρος-σοφός {oldWiseName} εντυπωσιάστηκε με το {specialItemQuest.ToLower()}.");
                    Console.ResetColor();
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"[1] Δείξε στον γέρο-σοφό {oldWiseNameRef} ένα εντυπωσιακό αντικείμενο.");
                    Console.ResetColor();
                }

                if (riddleSolved == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"[-] Έχεις λύσει τον γρίφο του {oldWiseNameOf}.");
                    Console.ResetColor();
                }

                else if (riddleSolved == false)
                {
                    Console.WriteLine($"[2] Λύσε τον γρίφο του γέρο-σοφού {oldWiseNameOf}.");
                }

                    if (weaponDMG == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"[3] Προσπάθησε να σκοτώσεις τον γέρο-σοφό.");
                    Console.ResetColor();
                }

                else
                {
                    Console.WriteLine($"[3] Προσπάθησε να σκοτώσεις τον γέρο-σοφό {oldWiseNameRef} με {weaponCall} σου.");
                }

                if (specialItemInput == "itemQuestComplete" && riddleSolved == true)
                {
                    Console.Write($"[4] Μπες στο κάστρο του ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Μεγάλου Κακού.");
                    Console.ResetColor();
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"[4] Μπες στο κάστρο του Μεγάλου Κακού.");
                    Console.ResetColor();
                }

                Console.WriteLine($"[5] Επιστροφή στο χωριό.");
                Console.WriteLine();

                dungeonChoice = Console.ReadLine();
                Console.WriteLine();

                if (dungeonChoice == "1")
                {
                    if (specialItemInput != null && specialItemInput != "itemQuestComplete")
                    {
                        Console.WriteLine($"- Ωωω, είπε ο γερο-σοφός {oldWiseName}. Αυτό το {specialItemInput.ToLower()} είναι πολύ εντυπωσιακό.");
                        Console.ResetColor();
                        specialItemInput = "itemQuestComplete";
                        specialItem = specialItemInput;
                        Console.WriteLine();
                        mechanics.PressAnyKey();
                    }

                    else if (specialItemInput == "itemQuestComplete")
                    {

                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Δεν έχεις κάποιο αντικείμενο που να είναι ιδιαίτερα εντυπωσιακό.");
                        Console.ResetColor();
                        Console.WriteLine();
                        mechanics.PressAnyKey();
                    }
                }

                else if (dungeonChoice == "2")
                {

                    if (riddleSolved == false && wrongRiddleCounter >= 3)
                    {
                        Console.WriteLine($"- Αν σε δυσκολεύει ο γρίφος, μπορούμε να τα βρούμε και μεταξύ μας, δεν ξέρω αν με πιάνεις, είπε ο γερο-σοφός {oldWiseName} και έκλεισε το μάτι στον βάρβαρο {heroName}.");
                        Console.WriteLine();

                        Console.Write("[1] Εντάξει, ορίστε ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("20 χρυσά νομίσματα");
                        Console.ResetColor();

                        Console.WriteLine("[2] Όχι, θα τα καταφέρω.");
                        Console.WriteLine();
                        bribeWise = Console.ReadLine();

                        if (bribeWise == "1")
                        {
                            gold = gold - 20;

                            riddleSolved = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine();
                            Console.WriteLine($"Ωωω, συγχαρητήρια βάρβαρε {heroNameCall}, και βέβαια έλυσες τον γρίφο, είπε ο γερο-σοφός {oldWiseName} και σκούντηξε τον βάρβαρο {heroName} με τον αγκώνα.");
                            Console.ResetColor();
                            Console.WriteLine();
                            mechanics.PressAnyKey();
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Εντάξει όπως νομίζεις βάρβαρε {heroNameCall}. Ορίστε ο γρίφος:");
                            Console.WriteLine();
                        }
                    }

                    
                    if (riddleSolved == false)
                    {

                        riddleSolved = mechanics.newPuzzle(devMode);

                        if (riddleSolved == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine();
                            Console.WriteLine($"Απάντησες σωστά στον γρίφο, βάρβαρε {heroNameCall}.");
                            Console.ResetColor();
                            Console.WriteLine();
                            mechanics.PressAnyKey();
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine();
                            Console.WriteLine($"Δεν είναι αυτή η απάντηση, βάρβαρε {heroNameCall}.");
                            Console.ResetColor();

                            wrongRiddleCounter++;

                            Console.WriteLine();
                            mechanics.PressAnyKey();
                        }
                    }
                }

                else if (dungeonChoice == "3")
                {

                    if (weaponDMG == 1)
                    {

                    }

                    else
                    {
                        Console.Write($"Ο βάρβαρος {heroName} σήκωσε {weaponCall} του και επιτέθηκε με όλη του τη δύναμη στο κεφάλι του γερο-σοφού {oldWiseNameOf}. ");

                        int weaponRandomTurnInto = mechanics.RollDiceMute(3);

                        switch (weaponRandomTurnInto)
                        {
                            case 1:
                                weapon = "Άγουρη μπανάνα";
                                weaponCall = "άγουρη μπανάνα";
                                break;

                            case 2:
                                weapon = "Χαλασμένο αγγούρι";
                                weaponCall = "χαλασμένο αγγούρι";
                                break;

                            case 3:
                                weapon = "Ψόφιο περιστέρι";
                                weaponCall = "ψόφιο περιστέρι";
                                break;
                        }

                        Console.WriteLine($"Μόνο ένα *πλοφ* ακοκύστηκε, καθώς το όπλο που κρατούσε είχε πλέον μεταμορφωθεί σε {weaponCall}.");
                        Console.ResetColor();

                        newWeapon = weapon;
                        newWeaponDMG = 1;
                        weaponDMG = newWeaponDMG;

                        Console.WriteLine();
                        mechanics.PressAnyKey();
                    }
                }

                else if (dungeonChoice == "4")
                {

                    if (specialItemInput == "itemQuestComplete" && riddleSolved == true)
                    {
                        Console.WriteLine($"Είσαι σίγουρος ότι θες να μπεις στο κάστρο; Να ξέρεις ότι δεν υπάρχει γυρισμός.");
                        Console.WriteLine();
                        Console.WriteLine($"[1] Για να συνεχίσεις, ή οποιοδήποτε πλήκτρο για να επιστρέψεις");
                        Console.ResetColor();
                        Console.WriteLine();
                          
                        confirmChoice = Console.ReadLine();

                        if (confirmChoice == "1")
                        {
                            Console.WriteLine();

                            if (armor == "Πέτρινη πανοπλία")
                            {
                                Console.WriteLine($"- Πολύ καλά βάρβαρε {heroNameCall}, καλή τύχη. Αλλά πριν μπεις, άσε με να κάνω ένα ξόρκι στην πανοπλία σου για να γίνει ακόμα πιο πέτρινη.");

                            }

                            else
                            {
                                Console.WriteLine($"- Πολύ καλά βάρβαρε {heroNameCall}, καλή τύχη. Αλλά πριν μπεις, άσε με να κάνω ένα ξόρκι σ' αυτή την αηδία που φοράς για να γίνει πιο ανθεκτική.");
                            }

                            armorDEF = 15;
                            Console.WriteLine();

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"DEF: 15");
                            Console.ResetColor();

                            Console.WriteLine();
                            mechanics.PressAnyKey();
                          
                            Console.WriteLine($"- Άσε με να σου κάνω και άλλο ένα μαγικό ξόρκι για να είσαι πιο υγειής.");

                            // Ζάρι
                            Console.WriteLine();
                            int dice = mechanics.RollDice(20);
                            Console.WriteLine();

                            // Hit or heal

                            if (dice <= 13)
                            {
                                Console.WriteLine($"Πράσινος καπνός βγήκε από τα αυτιά του βάρβαρου {heroNameCall}, ο οποίος ένιωσε έναν δυνατό πονοκέφαλο.");
                                Console.WriteLine();
                                life = mechanics.ChangeLife(life, 2, "hit", dice);
                                Console.WriteLine();
                                Console.WriteLine($"-Ευχαριστώ γέρο-σοφέ {oldWiseNameCall}, μας υποχρέωσες, είπε ο βάρβαρος {heroName}.");
                            }

                            else
                            {
                                Console.WriteLine($"Ακούστηκε ένα ελαφρύ 'παφ' και ο {heroName} ένιωσε έναν ευχάριστο γαργαλητό.");
                                Console.WriteLine();
                                life = mechanics.ChangeLife(life, 2, "heal", dice);
                                Console.WriteLine();
                                Console.WriteLine($"- Ευχαριστώ γέρο-σοφέ {oldWiseNameCall}, είπε ο βάρβαρος {heroName}.");
                            }

                            Console.WriteLine($"Οπλισμένος με το {weaponCall.ToLower()} του, και {armorCall.ToLower()} του, μπήκε στο κάστρο.");
                            Console.WriteLine();
                            mechanics.PressAnyKey();

                            battle.battleEnemy(heroName, life, weapon, weaponCall, weaponDMG, armor, armorDEF, potion, gold, specialItem, lamp, area, 0, bossName, out string battleResult, out life, out potion, out gold);

                            if (battleResult == "gameOver")
                            {
                                art.Dead(heroName);
                                Environment.Exit(0);
                            }

                            else if (battleResult == "bossDead")
                            {
                                Console.Clear();
                                area = "                       ΣΠΙΤΙ ΤΟΥ ΒΑΡΒΑΡΟΥ";

                                mechanics.ShowLife(life);
                                mechanics.ShowInventory(weapon, weaponDMG, armor, armorDEF, potion, gold, specialItem, lamp);
                                mechanics.ShowArea(area);

                                Console.WriteLine();
                                Console.WriteLine($"Ο βάρβαρος {heroName} επέστρεψε ικανοποιημένος στο σπίτι του. Έβγαλε το {armorCall} του, φύλαξε {weaponCall} του στο αγαπημένο του σεντούκι, και ξάπλωσε να κοιμηθεί.");
                                Console.WriteLine();

                                art.Win();
                                
                                Environment.Exit(0);
                            }
                        }

                        else
                        {
                            confirmChoice = null;
                            dungeonChoice = null;  
                        }
                    }

                    else
                    {

                    }
                }

                else if (dungeonChoice == "5")
                {
                    exitCastle = true;
                    returnToArea = "                            ΧΩΡΙΟ";
                }
            }
        }
    }
}
