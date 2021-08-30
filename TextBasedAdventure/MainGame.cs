using System;
using System.Text.RegularExpressions;

namespace TextBasedAdventure
{

    class Program
    {
        static void Main(string[] args)
        {
            // Ζάρι και ζωή
            int dice = 0;
            int life = 50;
            string area = null;

            // Inventory
            string weapon = null;
            string weaponCall = null;

            int weaponDMG = 4;
            string armor = null;
            string armorCall = null;
            int armorDEF = 1;
            int potion = 1;
            int gold = 20;
            string specialItemQuest = "Μυστήριο κουτάκι";
            string specialItem = null;
            string lamp = null;

            // Όνομα του ήρωα
            string heroName = null;
            string heroNameCall = null;
            string heroNameRef = null;
            string heroNameOf = null;

            // Όνομα του σοφού
            string oldWiseName = null;
            string oldWiseNameCall = null;
            string oldWiseNameRef = null;
            string oldWiseNameOf = null;

            // Όνομα του εμπόρου
            string merchName = null;
            string merchNameCall = null;
            string merchNameRef = null;
            string merchNameOf = null;

            // Όνομα του Μεγάλου Κακού
            string bossName = null;
            string bossNameCall = null;
            string bossNameRef = null;
            string bossNameOf = null;


            string devMode = null;
            string navigateMain = null;

            bool riddleSolved = false;

            // Null παράμετροι για μεθόδους       
            string name = null;
            string nameCall = null;
            string nameRef = null;
            string nameOf = null;
            string battleResult = null;
            int startEquipment = 0;

            // Instances μεθόδων

            TextBasedAdventure.NameCallClass newNameCall = new TextBasedAdventure.NameCallClass();
            TextBasedAdventure.Mechanics mechanics = new TextBasedAdventure.Mechanics();
            TextBasedAdventure.Battle battle = new TextBasedAdventure.Battle();
            TextBasedAdventure.Merchant merchant = new TextBasedAdventure.Merchant();
            TextBasedAdventure.FinalBoss boss = new TextBasedAdventure.FinalBoss();
            TextBasedAdventure.Art art = new TextBasedAdventure.Art();
            Regex onlyLetters = new Regex("^[a-zA-Zα-ωΑ-ΩάόέίύήΆΈΊΌΏΉΎ]*$");


            // Εισαγωγή  -----------------------------------------------------------------

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            // Art τίτλου
            art.Title();

            // Όνομα του ήρωα

            Console.WriteLine("Πώς λέγεται ο ήρωάς σου;");

            bool validHeroName = false;

            while (validHeroName == false)
            {
                heroName = Console.ReadLine();

                // Ενεργοποίηση dev mode

                if (heroName == "dev" || heroName == "Dev" || heroName == "DEV")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("--- Dev mode ---------------------");
                    Console.WriteLine();
                    Console.WriteLine("[1] Πλήρες inventory");
                    Console.WriteLine("[2] Λύση γρίφου");
                    Console.WriteLine("[3] Πλήρες inventory + λύση γρίφου");
                    Console.WriteLine("[4] Κανονικό παιχνίδι");
                    Console.WriteLine();

                    devMode = Console.ReadLine();

                    switch (devMode)
                    {
                        case "1":
                        case "3":
                            gold = 999;
                            life = 100;
                            potion = 99;
                            break;

                        case "4":
                            devMode = null;
                            break;
                    }

                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("Πώς λέγεται ο ήρωάς σου;");
                }

                // Αν δεν βάλει όνομα ήρωα, μπαίνει προεπιλεγμένο

                else if (string.IsNullOrEmpty(heroName))
                {
                    heroName = "Κόναρ";
                    Console.WriteLine("Κόναρ");
                    validHeroName = true;
                }

                // Πρέπει να είναι μόνο γράμματα. Δεν επιτρέπω σκέτες τις καταλήξεις γιατί δημιουργεί πρόβλημα στο NameCall()

                else if (onlyLetters.IsMatch(heroName))
                {
                    if (heroName == "ος" || heroName == "ός" || heroName == "ης" || heroName == "ής" || heroName == "ιος" || heroName == "ας" || heroName == "άς")
                    {
                        Console.WriteLine("Αυτό το όνομα δεν είναι διαθέσιμο, δοκίμασε ξανά.");
                    }

                    else
                    {
                        validHeroName = true;
                    }
                }

                else
                {
                    Console.WriteLine("Το όνομα πρέπει να περιέχει μόνο γράμματα, δοκίμασε ξανά.");
                }
            }

            newNameCall.NameCall(heroName, out name, out nameCall, out nameRef, out nameOf);

            heroName = name;
            heroNameCall = nameCall;
            heroNameRef = nameRef;
            heroNameOf = nameOf;


            // Όνομα του σοφού

            Console.WriteLine();
            Console.WriteLine("Πώς λέγεται ο γέρος-σοφός;");

            bool validWiseName = false;

            while (validWiseName == false)
            {
                oldWiseName = Console.ReadLine();

            // Αν δεν βάλει όνομα σοφού, μπαίνει προεπιλεγμένο

            if (string.IsNullOrEmpty(oldWiseName))
            {
                    oldWiseName = "Ιγνάτιος";
                    validWiseName = true;
                    Console.WriteLine("Ιγνάτιος");
            }

                // Πρέπει να είναι μόνο γράμματα. Δεν επιτρέπω σκέτες τις καταλήξεις γιατί δημιουργεί πρόβλημα στο NameCall()

                if (onlyLetters.IsMatch(oldWiseName))
                {
                    if (oldWiseName == "ος" || oldWiseName == "ός" || oldWiseName == "ης" || oldWiseName == "ής" || oldWiseName == "ιος" || oldWiseName == "ας" || oldWiseName == "άς")
                    {
                        Console.WriteLine("Αυτό το όνομα δεν είναι διαθέσιμο, δοκίμασε ξανά.");
                    }

                    else
                    {
                        validWiseName = true;
                    }
                }

                else
                {
                    Console.WriteLine("Το όνομα πρέπει να περιέχει μόνο γράμματα, δοκίμασε ξανά.");
                }
            }

            newNameCall.NameCall(oldWiseName, out name, out nameCall, out nameRef, out nameOf);

            oldWiseName = name;
            oldWiseNameCall = nameCall;
            oldWiseNameRef = nameRef;
            oldWiseNameOf = nameOf;


            // Όνομα του εμπόρου

            Console.WriteLine();
            Console.WriteLine("Πώς λέγεται ο έμπορος;");

            bool validMerchName = false;

            while (validMerchName == false)
            {
                merchName = Console.ReadLine();

                // Αν δεν βάλει όνομα σοφού, μπαίνει προεπιλεγμένο

                if (string.IsNullOrEmpty(merchName))
                {
                    merchName = "Σαράφης";
                    validMerchName = true;
                    Console.WriteLine("Σαράφης");
                }

                if (onlyLetters.IsMatch(merchName))
                {
                    if (merchName == "ος" || merchName == "ός" || merchName == "ης" || merchName == "ής" || merchName == "ιος" || merchName == "ας" || merchName == "άς")
                    {
                        Console.WriteLine("Αυτό το όνομα δεν είναι διαθέσιμο, δοκίμασε ξανά.");
                    }

                    else
                    {
                        validMerchName = true;
                    }
                }

                else
                {
                    Console.WriteLine("Το όνομα πρέπει να περιέχει μόνο γράμματα, δοκίμασε ξανά.");
                }
            }

            newNameCall.NameCall(merchName, out name, out nameCall, out nameRef, out nameOf);

            merchName = name;
            merchNameCall = nameCall;
            merchNameRef = nameRef;
            merchNameOf = nameOf;


            // Όνομα του Μεγάλου Κακού

            Console.WriteLine();
            Console.WriteLine("Πώς λέγεται ο Μεγάλος Κακός;");

            bool validBossName = false;

            while (validBossName == false)
            {
                bossName = Console.ReadLine();

                // Αν δεν βάλει όνομα σοφού, μπαίνει προεπιλεγμένο

                if (string.IsNullOrEmpty(bossName))
                {
                    bossName = "Κοφτεροδόντης";
                    validBossName = true;
                    Console.WriteLine("Κοφτεροδόντης");
                }

                if (onlyLetters.IsMatch(merchName))
                {
                    if (merchName == "ος" || merchName == "ός" || merchName == "ης" || merchName == "ής" || merchName == "ιος" || merchName == "ας" || merchName == "άς")
                    {
                        Console.WriteLine("Αυτό το όνομα δεν είναι διαθέσιμο, δοκίμασε ξανά.");
                    }

                    else
                    {
                        validBossName = true;
                    }
                }

                else
                {
                    Console.WriteLine("Το όνομα πρέπει να περιέχει μόνο γράμματα, δοκίμασε ξανά.");
                }
            }

            newNameCall.NameCall(bossName, out name, out nameCall, out nameRef, out nameOf);

            bossName = name;
            bossNameCall = nameCall;
            bossNameRef = nameRef;
            bossNameOf = nameOf;

            Console.WriteLine();
            mechanics.PressAnyKey();


            // Τυχαίο όπλο και πανοπλία

            startEquipment = mechanics.RollDiceMute(5);

            switch (startEquipment)
            {
                case 1:
                    weapon = "Παλιό τσεκούρι";
                    weaponCall = "το παλιό τσεκούρι";
                    break;
                case 2:
                    weapon = "Γιγάντιο ρόπαλο";
                    weaponCall = "το γιγάντιο ρόπαλο";
                    break;
                case 3:
                    weapon = "Σπαθάρα";
                    weaponCall = "την σπαθάρα";
                    break;
                case 4:
                    weapon = "Ξύλινο κοντάρι";
                    weaponCall = "το ξύλινο κοντάρι";
                    break;
                case 5:
                    weapon = "Πέτρες";
                    weaponCall = "τις πέτρες";
                    break;
                default:
                    break;
            }

            startEquipment = mechanics.RollDiceMute(4);


            switch (startEquipment)
            {
                case 1:
                    armor = "Δέρμα κατσίκας";
                    armorCall = "το δέρμα κατσίκας";
                    break;
                case 2:
                    armor = "Βρώμικο κουρέλι";
                    armorCall = "το βρώμικο κουρέλι";
                    break;
                case 3:
                    armor = "Γούνινο βρακάκι";
                    armorCall = "το γούνινο βρακάκι";
                    break;
                case 4:
                    armor = "Πέτσινη μπέρτα";
                    armorCall = "την πέτσινη μπέρτα";
                    break;
                default:
                    break;
            }

            // Αρχή ----------------------------------------------------------------------

            Console.Clear();

            area = "                            ΧΩΡΙΟ";

            mechanics.ShowLife(life);
            mechanics.ShowInventory(weapon, weaponDMG, armor, armorDEF, potion, gold, specialItem, lamp);
            mechanics.ShowArea(area);
            Console.WriteLine();

            Console.WriteLine($"Ο {heroName} μόλις που είχε ξυπνήσει, όταν μια φωνή ακούστηκε στην εξώπορτα.");
            Console.WriteLine();

            Console.WriteLine($"- Έι, βάρβαρε {heroNameCall}! Άνοιξέ μου! Χρειαζόμαστε τη βοήθειά σου!");
            Console.WriteLine();

            Console.WriteLine($"Ο {heroName} άνοιξε την πόρτα και αντίκρυσε τον {oldWiseNameRef}, τον γέρο-σοφό του χωριού.");
            Console.WriteLine();

            Console.WriteLine($"- Τι συμβαίνει γερο-σοφέ {oldWiseNameCall};");
            Console.WriteLine($"- Δεν έχουμε χρόνο να σου εξηγήσω βάρβαρε {heroNameCall}, πάρε γρήγορα {weaponCall.ToLower()} σου και πήγαινε στο δάσος. Αλλά πρώτα, άσε με να σου κάνω ένα μαγικό ξόρκι για να είσαι πιο υγειής.");


            // Ζάρι
            Console.WriteLine();
            dice = mechanics.RollDice(20);
            Console.WriteLine();

            // Hit or heal

            if (dice <= 10)
            {
                Console.WriteLine($"Πράσινος καπνός βγήκε από τα αυτιά του βάρβαρου {heroNameOf}, ο οποίος ένιωσε έναν δυνατό πονοκέφαλο.");
                Console.WriteLine();
                life = mechanics.ChangeLife(life, 1, "hit", dice);
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


            Console.WriteLine($"Πήρε {weaponCall.ToLower()} του, φόρεσε {armorCall.ToLower()} του και ξεκίνησε για το δάσος.");
            Console.WriteLine();
            mechanics.PressAnyKey();


            // Πλοήγηση 

            bool returnToMainNavigation = true;

            while (returnToMainNavigation = true)
            {

                Console.Clear();
                mechanics.ShowLife(life);
                mechanics.ShowInventory(weapon, weaponDMG, armor, armorDEF, potion, gold, specialItem, lamp);
                mechanics.ShowArea(area);
                Console.WriteLine();

                Console.WriteLine($"Πού θέλεις να πάει ο {heroName};");
                Console.WriteLine();
                Console.WriteLine("[1] Στο δάσος");
                Console.WriteLine("[2] Στη σπηλιά");
                Console.WriteLine("[3] Στον έμπορο");
                Console.WriteLine("[4] Στο κάστρο του Μεγάλου Κακού");
                Console.WriteLine();

                navigateMain = Console.ReadLine();
                Console.WriteLine();

                if (navigateMain == "1")
                {
                    area = "                            ΔΑΣΟΣ";
                    Console.Clear();
                    mechanics.ShowLife(life);
                    mechanics.ShowInventory(weapon, weaponDMG, armor, armorDEF, potion, gold, specialItem, lamp);
                    mechanics.ShowArea(area);


                    battle.battleEnemy(heroName, life, weapon, weaponCall, weaponDMG, armor, armorDEF, potion, gold, specialItem, lamp, area, 1, bossName, out battleResult, out life, out potion, out gold);


                    if (battleResult == "gameOver")
                    {

                        art.Dead(heroName);
                        Environment.Exit(0);
                    }

                    else if (battleResult == "enemyDead")
                    {
                        Console.WriteLine($"Ο {heroName} συνέχισε το ταξίδι του.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("[Πάτα ένα πλήκτρο για να επιστρέψεις στην πόλη...]");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();

                        area = "                            ΧΩΡΙΟ";
                    }

                    else if (battleResult == "ran")
                    {

                        Console.WriteLine($"Ο {heroName} συνέχισε το ταξίδι του.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("[Πάτα ένα πλήκτρο για να επιστρέψεις στην πόλη...]");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine();
                        area = "                            ΧΩΡΙΟ";
                    }

                }

                else if (navigateMain == "2")
                {
                    area = "                            ΣΠΗΛΙΑ";
                    Console.Clear();
                    mechanics.ShowLife(life);
                    mechanics.ShowInventory(weapon, weaponDMG, armor, armorDEF, potion, gold, specialItem, lamp);
                    mechanics.ShowArea(area);


                    if (lamp != null)
                    {
                        battle.battleEnemy(heroName, life, weapon, weaponCall, weaponDMG, armor, armorDEF, potion, gold, specialItem, lamp, area, 2, bossName, out battleResult, out life, out potion, out gold);

                        if (battleResult == "gameOver")
                        {
                            art.Dead(heroName);
                            Environment.Exit(0);
                        }

                        else if (battleResult == "enemyDead")
                        {
                            Console.WriteLine($"Ο {heroName} συνέχισε το ταξίδι του.");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("[Πάτα ένα πλήκτρο για να επιστρέψεις στην πόλη...]");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.WriteLine();

                            area = "ΧΩΡΙΟ";
                        }

                        else if (battleResult == "ran")
                        {

                            Console.WriteLine($"Ο {heroName} συνέχισε το ταξίδι του.");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("[Πάτα ένα πλήκτρο για να επιστρέψεις στην πόλη...]");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.WriteLine();
                            area = "                            ΧΩΡΙΟ";
                        }
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Ο βάρβαρος {heroName} μπήκε στη σπηλιά. Ήταν θεοσκότεινα και δεν έβλεπε την τύφλα του.");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.ReadKey();
                        area = "                            ΧΩΡΙΟ";
                    }
                }

                else if (navigateMain == "3")
                {
                    area = "                           ΕΜΠΟΡΟΣ";

                   
                    merchant.NewMerchant(heroName, life, weapon, weaponCall, weaponDMG, armor, armorCall, armorDEF, potion, gold, specialItem, specialItemQuest, lamp, area, merchName, out area, out weapon, out weaponCall, out weaponDMG, out armor, out armorCall, out armorDEF, out gold, out potion, out specialItem, out lamp);

                }

                else if (navigateMain == "4")
                {
                    area = "                      ΚΑΣΤΡΟ ΤΟΥ ΜΕΓΑΛΟΥ ΚΑΚΟΥ";

                    boss.newBoss(heroName, oldWiseName, life, weapon, weaponCall, weaponDMG, armor, armorCall, armorDEF, potion, gold, specialItem, specialItemQuest, lamp, area, bossName, riddleSolved, devMode, out area, out specialItem, out weapon, out weaponCall, out weaponDMG, out riddleSolved);

                }
            }
        }
    }
}


