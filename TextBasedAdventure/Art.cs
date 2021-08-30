using System;
namespace TextBasedAdventure
{
    public class Art
    {


        public void Title()
        {
            Console.WriteLine("               ΤΟ ΕΠΟΣ ΤΟΥ ΒΑΡΒΑΡΟΥ");
            Console.WriteLine("         />_________________________________");
            Console.WriteLine("[########[]_________________________________>");
            Console.WriteLine("         \\>");
            Console.WriteLine();
            Console.ResetColor();
        }

        public void Dead(string heroName)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"O {heroName} πέθανε.");
            Console.WriteLine();

            Console.WriteLine("                                 ,--.");
            Console.WriteLine("                                {    }");
            Console.WriteLine("                                K,   }");
            Console.WriteLine("                               /  ~Y`");
            Console.WriteLine("                          ,   /   /");
            Console.WriteLine("                         {_'-K.__/");
            Console.WriteLine("                           `/-.__L._");
            Console.WriteLine("                           /  ' /`\\_}");
            Console.WriteLine("                          /  ' /");
            Console.WriteLine("                ____     /  ' /");
            Console.WriteLine("           ,-'~~~~    ~~/  ' /_");
            Console.WriteLine("         ,'             ``~~~  ',");
            Console.WriteLine("        (                        Y");
            Console.WriteLine("       {                         I");
            Console.WriteLine("      {      -                    `,");
            Console.WriteLine("      |       ',                   )");
            Console.WriteLine("      |        |   ,..__      __. Y");
            Console.WriteLine("      |    .,_./  Y ' / ^Y   J   )|");
            Console.WriteLine("      \\           |' /   |   |   ||");
            Console.WriteLine("       \\          L_/    . _ (_,.'(");
            Console.WriteLine("        \\,   ,      ^^\"\"' / |      )");
            Console.WriteLine("          \\_  \\          /,L]     /");
            Console.WriteLine("            '-_~-,       ` `   ./`");
            Console.WriteLine("               `'{_            )");
            Console.WriteLine("                   ^^\\..___,.--`");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                       ΤΕΛΟΣ");






        }

        public void Win()
        {
            Console.WriteLine();
            Console.WriteLine("                           (   )");
            Console.WriteLine("                          (    )");
            Console.WriteLine("                           (    )");
            Console.WriteLine("                          (    )");
            Console.WriteLine("                            )  )");
            Console.WriteLine("                           (  (                  /\\");
            Console.WriteLine("                            (_)                 /  \\  /\\");
            Console.WriteLine("                    ________[_]________      /\\/    \\/  \\");
            Console.WriteLine("           /\\      /\\        ______    \\    /   /\\/\\  /\\/\\");
            Console.WriteLine("          /  \\    //_\\       \\    /\\    \\  /\\/\\/    \\/    \\");
            Console.WriteLine("   /\\    / /\\/\\  //___\\       \\__/  \\    \\/");
            Console.WriteLine("  /  \\  /\\/    \\//_____\\       \\ |[]|     \\");
            Console.WriteLine(" /\\/\\/\\/       //_______\\       \\|__|      \\");
            Console.WriteLine("/      \\      /XXXXXXXXXX\\                  \\");
            Console.WriteLine("        \\    /_I_II  I__I_\\__________________\\");
            Console.WriteLine("               I_I|  I__I_____[]_|_[]_____I");
            Console.WriteLine("               I_II  I__I_____[]_|_[]_____I");
            Console.WriteLine("               I II__I  I     XXXXXXX     I");
            Console.WriteLine("            ~~~~~\"   \"~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                         ΤΕΛΟΣ");

        }
    }
}
