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

            int weaponDMG = 2;
            string armor = null;
            string armorCall = null;
            int armorDEF = 1;
            int potion = 1;
            int gold = 20;

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



            string navigateMain = null;
            string specialItem = null;

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
            Regex onlyLetters = new Regex("^[a-zA-Zα-ωΑ-ΩάόέίύήΆΈΊΌΏΉΎ]*$");





            // Εισαγωγή  -----------------------------------------------------------------

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("               ΤΟ ΕΠΟΣ ΤΟΥ ΒΑΡΒΑΡΟΥ");
            Console.WriteLine("         />_________________________________");
            Console.WriteLine("[########[]_________________________________>");
            Console.WriteLine("         \\>");
            Console.WriteLine();
            Console.ResetColor();



            // Όνομα του ήρωα

            Console.WriteLine("Πώς λέγεται ο ήρωάς σου;");

            bool validHeroName = false;

            while (validHeroName == false)
            {
                heroName = Console.ReadLine();

                // Αν δεν βάλει όνομα ήρωα, μπαίνει προεπιλεγμένο

                if (string.IsNullOrEmpty(heroName))
                {
                    heroName = "Κόναρ";
                    Console.WriteLine("Κόναρ");
                    validHeroName = true;
                }

                if (onlyLetters.IsMatch(heroName))
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

            area = "ΧΩΡΙΟ";

            mechanics.ShowLife(life);
            mechanics.ShowInventory(weapon, weaponDMG, armor, armorDEF, potion, gold, specialItem);
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


            Console.WriteLine($"Πήρε {weaponCall.ToLower()} του, φόρεσε {armorCall.ToLower()} του και ξεκίνησε για το δάσος.");
            Console.WriteLine();
            mechanics.PressAnyKey();


            // Πλοήγηση 

            bool returnToMainNavigation = true;



            while (returnToMainNavigation = true)
            {

                Console.Clear();
                mechanics.ShowLife(life);
                mechanics.ShowInventory(weapon, weaponDMG, armor, armorDEF, potion, gold, specialItem);
                mechanics.ShowArea(area);
                Console.WriteLine();

                Console.WriteLine($"Πού θέλεις να πάει ο {heroName};");
                Console.WriteLine();
                Console.WriteLine("[1] Στο δάσος");
                Console.WriteLine("[2] Στη σπηλιά");
                Console.WriteLine("[3] Στον έμπορο");
                Console.WriteLine();

                navigateMain = Console.ReadLine();
                Console.WriteLine();



                if (navigateMain == "1")
                {
                    area = "ΔΑΣΟΣ";
                    Console.Clear();
                    mechanics.ShowLife(life);
                    mechanics.ShowInventory(weapon, weaponDMG, armor, armorDEF, potion, gold, specialItem);
                    mechanics.ShowArea(area);


                    battle.battleEnemy(heroName, life, weapon, weaponCall, weaponDMG, armor, armorDEF, potion, gold, specialItem, area, 1, out battleResult, out life, out potion, out gold);


                    if (battleResult == "gameOver")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"O {heroName} πέθανε.");
                        Console.WriteLine("ΤΕΛΟΣ");
                        Console.ResetColor();
                        Console.ReadKey();
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
                        area = "ΧΩΡΙΟ";
                    }

                }

                else if (navigateMain == "2")
                {
                    area = "ΣΠΗΛΙΑ";
                    Console.Clear();
                    mechanics.ShowLife(life);
                    mechanics.ShowInventory(weapon, weaponDMG, armor, armorDEF, potion, gold, specialItem);
                    mechanics.ShowArea(area);

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("...Under construction...");
                    Console.ResetColor();
                    Console.ReadKey();
                    area = "ΧΩΡΙΟ";

                }

                else if (navigateMain == "3")
                {
                    area = "ΕΜΠΟΡΟΣ";

                   
                    merchant.NewMerchant(heroName, life, weapon, weaponCall, weaponDMG, armor, armorCall, armorDEF, potion, gold, specialItem, area, merchName, out area, out weapon, out weaponCall, out weaponDMG, out armor, out armorCall, out armorDEF, out gold, out potion, out specialItem);


                }
            }

                // ΤΕΛΟΣ
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("...Under construction...");
                Console.ResetColor();
                Console.ReadKey();
                area = "ΧΩΡΙΟ";


            
        }
    }
}


