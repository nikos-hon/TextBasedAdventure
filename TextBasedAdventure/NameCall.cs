using System;
namespace TextBasedAdventure
{
    public class NameCallClass
    {

        // Τροποποίηση ονόματος

        public void NameCall(in string nameInput, out string name, out string nameCall, out string nameRef, out string nameOf)
        {

            string nameEnding = nameInput.Substring(nameInput.Length - 2);

            if (nameEnding == "ος")
            {
                string nameEndingThree = nameInput.Substring(nameInput.Length - 3);

                if (nameEndingThree == "ιος")
                {
                    name = nameInput;
                    nameCall = nameInput.Remove(name.Length - 2, 2) + "ε";
                    nameRef = nameInput.Remove(name.Length - 1, 1);
                    nameOf = nameInput.Remove(name.Length - 1, 1) + "υ";

                    // Console.ForegroundColor = ConsoleColor.Green;
                    // Console.WriteLine();
                    // Console.WriteLine($"Περίπτωση 1 -ιος");
                    // Console.WriteLine($"Το όνομα είναι {name}");
                    // Console.WriteLine($"Με φωνάζουν {nameCall}");
                    // Console.WriteLine($"Αναφέρονται στον {nameRef}");
                    // Console.WriteLine($"Αντικείμενα του {nameOf}");
                    // Console.ResetColor();
                }

                else if (nameEndingThree == "χος")
                {
                    name = nameInput;
                    nameCall = nameInput.Remove(name.Length - 2, 2) + "ε";
                    nameRef = nameInput.Remove(name.Length - 1, 1);
                    nameOf = nameInput.Remove(name.Length - 1, 1) + "υ";

                    // Console.ForegroundColor = ConsoleColor.Green;
                    // Console.WriteLine();
                    // Console.WriteLine($"Περίπτωση 1 -ιος");
                    // Console.WriteLine($"Το όνομα είναι {name}");
                    // Console.WriteLine($"Με φωνάζουν {nameCall}");
                    // Console.WriteLine($"Αναφέρονται στον {nameRef}");
                    // Console.WriteLine($"Αντικείμενα του {nameOf}");
                    // Console.ResetColor();
                }

                else if (nameEndingThree == "ρος")
                {
                    name = nameInput;
                    nameCall = nameInput.Remove(name.Length - 2, 2) + "ε";
                    nameRef = nameInput.Remove(name.Length - 1, 1);
                    nameOf = nameInput.Remove(name.Length - 1, 1) + "υ";

                    // Console.ForegroundColor = ConsoleColor.Green;
                    // Console.WriteLine();
                    // Console.WriteLine($"Περίπτωση 1 -ιος");
                    // Console.WriteLine($"Το όνομα είναι {name}");
                    // Console.WriteLine($"Με φωνάζουν {nameCall}");
                    // Console.WriteLine($"Αναφέρονται στον {nameRef}");
                    // Console.WriteLine($"Αντικείμενα του {nameOf}");
                    // Console.ResetColor();
                }

                else
                {
                    name = nameInput;
                    nameCall = nameInput.Remove(name.Length - 1, 1);
                    nameRef = nameInput.Remove(name.Length - 1, 1);
                    nameOf = nameInput.Remove(name.Length - 1, 1) + "υ";

                    // Console.ForegroundColor = ConsoleColor.Green;
                    // Console.WriteLine();
                    // Console.WriteLine($"Περίπτωση 2 -ος");
                    // Console.WriteLine($"Το όνομα είναι {name}");
                    // Console.WriteLine($"Με φωνάζουν {nameCall}");
                    // Console.WriteLine($"Αναφέρονται στον {nameRef}");
                    // Console.WriteLine($"Αντικείμενα του {nameOf}");
                    // Console.ResetColor();
                }
            }

            else if (nameEnding == "ός")
            {
                name = nameInput;
                nameCall = nameInput.Remove(name.Length - 2, 2) + "έ";
                nameRef = nameInput.Remove(name.Length - 1, 1);
                nameOf = nameInput.Remove(name.Length - 2, 2) + "ού";

                // Console.ForegroundColor = ConsoleColor.Green;
                // Console.WriteLine();
                // Console.WriteLine($"Περίπτωση 3 -ός");
                // Console.WriteLine($"Το όνομα είναι {name}");
                // Console.WriteLine($"Με φωνάζουν {nameCall}");
                // Console.WriteLine($"Αναφέρονται στον {nameRef}");
                // Console.WriteLine($"Αντικείμενα του {nameOf}");
                // Console.ResetColor();
            }

            else if (nameEnding == "ης")
            {
                name = nameInput;
                nameCall = nameInput.Remove(name.Length - 1, 1);
                nameRef = nameInput.Remove(name.Length - 1, 1);
                nameOf = nameInput.Remove(name.Length - 1, 1);

                // Console.ForegroundColor = ConsoleColor.Green;
                // Console.WriteLine();
                // Console.WriteLine($"Περίπτωση 4 -ης");
                // Console.WriteLine($"Το όνομα είναι {name}");
                // Console.WriteLine($"Με φωνάζουν {nameCall}");
                // Console.WriteLine($"Αναφέρονται στον {nameRef}");
                // Console.WriteLine($"Αντικείμενα του {nameOf}");
                // Console.ResetColor();
            }

            else if (nameEnding == "ής")
            {
                name = nameInput;
                nameCall = nameInput.Remove(name.Length - 1, 1);
                nameRef = nameInput.Remove(name.Length - 1, 1);
                nameOf = nameInput.Remove(name.Length - 1, 1);

                // Console.ForegroundColor = ConsoleColor.Green;
                // Console.WriteLine();
                // Console.WriteLine($"Περίπτωση 5 -ής");
                // Console.WriteLine($"Το όνομα είναι {name}");
                // Console.WriteLine($"Με φωνάζουν {nameCall}");
                // Console.WriteLine($"Αναφέρονται στον {nameRef}");
                // Console.WriteLine($"Αντικείμενα του {nameOf}");
                // Console.ResetColor();
            }

            else if (nameEnding == "ας")
            {
                name = nameInput;
                nameCall = nameInput.Remove(name.Length - 1, 1);
                nameRef = nameInput.Remove(name.Length - 1, 1);
                nameOf = nameInput.Remove(name.Length - 1, 1);

                // Console.ForegroundColor = ConsoleColor.Green;
                // Console.WriteLine();
                // Console.WriteLine($"Περίπτωση 6 -ας");
                // Console.WriteLine($"Το όνομα είναι {name}");
                // Console.WriteLine($"Με φωνάζουν {nameCall}");
                // Console.WriteLine($"Αναφέρονται στον {nameRef}");
                // Console.WriteLine($"Αντικείμενα του {nameOf}");
                // Console.ResetColor();
            }

            else if (nameEnding == "άς")
            {
                name = nameInput;
                nameCall = nameInput.Remove(name.Length - 2, 2) + "ά";
                nameRef = nameInput.Remove(name.Length - 1, 1);
                nameOf = nameInput.Remove(name.Length - 1, 1);

                // Console.ForegroundColor = ConsoleColor.Green;
                // Console.WriteLine();
                // Console.WriteLine($"Περίπτωση 7 -άς");
                // Console.WriteLine($"Το όνομα είναι {name}");
                // Console.WriteLine($"Με φωνάζουν {nameCall}");
                // Console.WriteLine($"Αναφέρονται στον {nameRef}");
                // Console.WriteLine($"Αντικείμενα του {nameOf}");
                // Console.ResetColor();
            }

            else
            {
                name = nameInput;
                nameCall = name;
                nameRef = nameInput;
                nameOf = nameInput;

                // Console.ForegroundColor = ConsoleColor.Green;
                // Console.WriteLine();
                // Console.WriteLine($"Περίπτωση 8 - άλλο");
                // Console.WriteLine($"Το όνομα είναι {name}");
                // Console.WriteLine($"Με φωνάζουν {nameCall}");
                // Console.WriteLine($"Αναφέρονται στον {nameRef}");
                // Console.WriteLine($"Αντικείμενα του {nameOf}");
                // Console.ResetColor();
            }
        }
    }
}
