using System;
namespace TextBasedAdventure
{
    public class Battle
    {

        string name = null;
        string nameCall = null;
        string nameRef = null;
        string nameOf = null;
        string battleResult = null;
        string enemyName = null;
        string enemyNameCall = null;
        string enemyNameRef = null;
        string enemyNameNameOf = null;
        string enemyAttack = null;
        string nextTurn = null;

        
        int newEnemyHp = 0;
        int newEnemySTR = 0;
        int damage = 0;
        int dice = 0;
        int randomEnemyAttack = 0;
        string EnemyAttack = null;
        string enemyArticle = null;

        // Όνομα του ήρωα
        string heroName = null;
        string heroNameCall = null;
        string heroNameRef = null;
        string heroNameOf = null;

        TextBasedAdventure.NameCallClass newNameCall = new TextBasedAdventure.NameCallClass();
        TextBasedAdventure.Mechanics mechanics = new TextBasedAdventure.Mechanics();


        // Μάχη με εχθρό

        public void battleEnemy(string playerName, int playerHealth, string weapon, string weaponCall, int weaponDMG, string armor, int armorDEF, int potionNumber, int goldAmount, string specialObject, string area, int enemyLevel, out string battleResult, out int life, out int potion, out int gold)
        {


            newNameCall.NameCall(playerName, out name, out nameCall, out nameRef, out nameOf);

            heroName = name;
            heroNameCall = nameCall;
            heroNameRef = nameRef;
            heroNameOf = nameOf;

            bool runAway = false;
            Random enemyHp = new Random();
            Random enemySTR = new Random();
            Random lootRand = new Random();


            // Τύπος εχθρού

            int enemySpawn = mechanics.RollDiceMute(4);

            switch (enemySpawn)
            {
                case 1:
                    enemyName = "Θυμωμένος λεπρός";
                    enemyArticle = "Ο";
                    enemyNameCall = "Θυμωμένε λεπρέ";
                    enemyNameRef = "τον Θυμωμένο λεπρό";
                    enemyNameNameOf = "του Θυμωμένου λεπρού";
                    break;
                case 2:
                    enemyName = "Μοχθηρός νάνος";
                    enemyArticle = "Ο";
                    enemyNameCall = "μοχθηρέ νάνε";
                    enemyNameRef = "τον μοχθηρό νάνο";
                    enemyNameNameOf = "του μοχθηρού νάνου";
                    break;
                case 3:
                    enemyName = "Γιγάντια μύγα";
                    enemyArticle = "Η";
                    enemyNameCall = "γιγάντια μύγα";
                    enemyNameRef = "τη γιγάντια μύγα";
                    enemyNameNameOf = "της γιγάντιας μύγας";
                    break;
                case 4:
                    enemyName = "Βρωμιάρης καλικάντζαρος";
                    enemyArticle = "Ο";
                    enemyNameCall = "βρωμιάρη καλικάντζαρε";
                    enemyNameRef = "τον βρωμιάρη καλικάντζαρο";
                    enemyNameNameOf = "του βρωμιάρη καλικάντζαρου";
                    break;
            }


            // Δυσκολία εχθρού

            if (enemyLevel == 1)
            {
                newEnemyHp = enemyHp.Next(4, 7);
                newEnemySTR = enemySTR.Next(4, 7);
            }

            nextTurn = "player";

            while (playerHealth > 0 && newEnemyHp > 0 && runAway == false)
            {

                if (nextTurn == "player")
                {

                    Console.Clear();
                    mechanics.ShowLife(playerHealth);
                    mechanics.ShowInventory(weapon, weaponDMG, armor, armorDEF, potionNumber, goldAmount, specialObject);
                    mechanics.ShowArea(area);
                    Console.WriteLine();
                    Console.WriteLine("Ένας εχθρός εμφανίστηκε.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{enemyName} Level {enemyLevel} - HP {newEnemyHp}");
                    Console.ResetColor();
                    Console.WriteLine();

                    Console.WriteLine("Τι θέλεις να κάνεις;");
                    Console.WriteLine();
                    Console.WriteLine("[1] Επίθεση");
                    Console.WriteLine("[2] Φίλτρο +50 HP");
                    Console.WriteLine("[3] Φεύγω");
                    Console.WriteLine();

                    string battleChoise = Console.ReadLine();
                    Console.WriteLine();


                    // Αν επιλέξει [1] Επίθεση

                    if (battleChoise == "1")
                    {

                        Console.WriteLine($"O βάρβαρος {heroName} επιτίθεται με {weaponCall}.");
                        Console.WriteLine();
                        dice = mechanics.RollDiceNoWait(20);


                        if (dice >= 10)
                        {
                            damage = weaponDMG;
                            newEnemyHp = newEnemyHp - damage;

                        }

                        else if (dice >= 7 && dice < 10)
                        {
                            damage = weaponDMG / 2;
                            newEnemyHp = newEnemyHp - damage;
                        }

                        else if (dice < 7)
                        {
                            damage = 0;
                            newEnemyHp = newEnemyHp - damage;
                        }

                        if (newEnemyHp < 0)
                        {
                            newEnemyHp = 0;
                        }

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"[Damage]: {damage}");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;


                        // Αν ο εχθρός πεθάνει

                        if (newEnemyHp == 0)
                        {
                            Console.WriteLine($"{enemyArticle} {enemyName.ToLower()} πέθανε.");
                        }

                        else
                        {
                            Console.WriteLine($"{enemyName} Level {enemyLevel} - HP {newEnemyHp}");
                        }


                        Console.ResetColor();


                        nextTurn = "enemy";


                    }

                    // Αν επιλέξει [2] Φίλτρο

                    else if (battleChoise == "2")
                    {
                        if (potionNumber > 0)
                        {
                            playerHealth = playerHealth + 50;

                            if (playerHealth > 100)
                            {
                                playerHealth = 100;
                            }

                            potionNumber--;
                            nextTurn = "enemy";

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Φίλτρο HP +50");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"[Ζωή 0-100]: {playerHealth}");
                            Console.ResetColor();
                            Console.WriteLine();
                        }

                        else
                        {
                            Console.WriteLine("Δεν έχεις κανένα φίλτρο.");
                        }

                    }


                    // Αν επιλέξει [3] Φεύγω

                    else if (battleChoise == "3")
                    {

                        dice = mechanics.RollDiceNoWait(20);

                        if (dice >= 5)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ξέφυγες από {enemyNameRef}.");
                            Console.WriteLine();
                            runAway = true;
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Δεν κατάφερες να ξεφύγεις από {enemyNameRef}!");
                            nextTurn = "enemy";
                        }

                    }

                }

                // Μάχη - η σειρά του αντιπάλου

                else if (nextTurn == "enemy")
                {

                    randomEnemyAttack = mechanics.RollDiceMute(3);


                    switch (enemyName)
                    {
                        case "Θυμωμένος λεπρός":

                            switch (randomEnemyAttack)
                            {
                                case 1:
                                    EnemyAttack = "λέπρα";
                                    break;
                                case 2:
                                    EnemyAttack = "χλέπες";
                                    break;
                                case 3:
                                    EnemyAttack = "κλωτσιές";
                                    break;
                            }
                            break;

                        case "Μοχθηρός νάνος":
                            switch (randomEnemyAttack)
                            {
                                case 1:
                                    EnemyAttack = "μικρό τσεκουράκι";
                                    break;
                                case 2:
                                    EnemyAttack = "κουτουλιά";
                                    break;
                                case 3:
                                    EnemyAttack = "γονατιά";
                                    break;
                            }
                            break;

                        case "Γιγάντια μύγα":
                            switch (randomEnemyAttack)
                            {
                                case 1:
                                    EnemyAttack = "τα ποδαράκια της";
                                    break;
                                case 2:
                                    EnemyAttack = "το κεντρί";
                                    break;
                                case 3:
                                    EnemyAttack = "φτυσιές";
                                    break;
                            }
                            break;

                        case "Βρωμιάρης καλικάντζαρος":
                            switch (randomEnemyAttack)
                            {
                                case 1:
                                    EnemyAttack = "με μαχαίρι";
                                    break;
                                case 2:
                                    EnemyAttack = "κλωτσιά στο γόνατο";
                                    break;
                                case 3:
                                    EnemyAttack = "βρωμιές";
                                    break;
                            }
                            break;



                    }

                    Console.WriteLine($"{enemyArticle} {enemyName.ToLower()} επιτίθεται με {EnemyAttack}.");
                    Console.WriteLine();
                    dice = mechanics.RollDiceNoWait(20);

                    if (dice >= 16)
                    {
                        damage = 0;
                        playerHealth = playerHealth - damage;
                    }

                    else if (dice >= 10 && dice < 16)
                    {
                        damage = (newEnemySTR / 2) - (armorDEF / 2);
                        playerHealth = playerHealth - damage;
                    }

                    else if (dice < 10)
                    {
                        damage = newEnemySTR - (armorDEF / 2);
                        playerHealth = playerHealth - damage;
                    }

                    if (playerHealth < 0)
                    {
                        playerHealth = 0;
                    }

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"[Damage]: {damage}");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"[Ζωή 0-100]: {playerHealth}");
                    Console.ResetColor();
                    Console.WriteLine();
                    nextTurn = "player";

                    mechanics.PressAnyKey();

                }
            }

            if (playerHealth == 0)
            {
                battleResult = "gameOver";
                life = playerHealth;
                potion = potionNumber;
                gold = goldAmount;
            }


            // Loot

            else if (newEnemyHp == 0)
            {

                int goldFound = enemyLevel * lootRand.Next(1, 5);
                gold = goldAmount + goldFound;
                Console.ForegroundColor = ConsoleColor.Yellow;

                if (goldFound == 1)
                {

                    Console.WriteLine($"Βρήκες {goldFound} χρυσό νόμισμα.");
                }

                else
                {
                    Console.WriteLine($"Βρήκες {goldFound} χρυσά νομίσματα.");
                }

                Console.WriteLine();
                Console.ResetColor();
                battleResult = "enemyDead";
                life = playerHealth;
                potion = potionNumber;

            }

            else if (runAway == true)
            {
                battleResult = "ran";
                life = playerHealth;
                potion = potionNumber;
                gold = goldAmount;
            }

            else
            {
                battleResult = "null";
                life = playerHealth;
                potion = potionNumber;
                gold = goldAmount;
            }


        }




    }
}
