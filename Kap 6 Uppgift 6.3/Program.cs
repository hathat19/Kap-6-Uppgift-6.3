using System;
using System.Collections.Generic;
namespace Uppgift6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Färger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            //-------------------------------------------

            string menuChoice = "";
            while (menuChoice != "3")
            {
                SkrivMeny();
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Menyval1();
                        break;

                    case "2":
                        Menyval2();
                        break;

                    case "3":
                        Console.WriteLine("Du stängde av programmet.");
                        break;

                    default:
                        Console.WriteLine("Du skrev inget giltigt menyalternativ. Försök igen.");
                        break;
                }
            }

        }

        static void SkrivMeny()
        {
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Addera tre tal\r\n2. Största talet av två tal\r\n3. Avsluta programmet");
        }

        static void Menyval1()
        {
            Console.WriteLine("Du valde att addera tre tal.");
            Console.WriteLine("Skriv tal 1:");
            int tal1 = ReadInt();
            Console.WriteLine("Skriv tal 2:");
            int tal2 = ReadInt();
            Console.WriteLine("Skriv tal 3:");
            int tal3 = ReadInt();
            Console.WriteLine($"{tal1} + {tal2} + {tal3} = {Addera(tal1,tal2,tal3)}.");
        }

        static void Menyval2()
        {
            Console.WriteLine("Du valde att hitta det största talet av två.");
            Console.WriteLine("Skriv tal 1:");
            int tal1 = ReadInt();
            Console.WriteLine("Skriv tal 2:");
            int tal2 = ReadInt();
            Console.WriteLine($"{Störst(tal1,tal2)} är det största talet av dem du skrev in.");
        }

        static int Addera(int a = 0, int b = 0, int c = 0)
        {
            return a + b + c;
        }

        /// <summary>
        /// Jämför två tal och returnerar det största. 
        /// </summary>
        /// <param name="tal1"></param>
        /// <param name="tal2"></param>
        /// <returns></returns>
        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2) return tal1;
            else return tal2;
        }
        static int ReadInt()
        {
            int integer;

            while (int.TryParse(Console.ReadLine(), out integer) == false)
            {
                Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
            }
            return integer;
        }
    }
}
/*Skapa ett menyprogram med följande alternativ
1. Addera tre tal
2. Största talet av två tal
3. Avsluta programmet
Programmet ska vara uppdelat i metoder, det ska finnas en metod för varje
menyalternativ. Programmet ska innehålla två metoder, MenyvalAddera
och MenyvalStörstaTalet, som hanterar de båda menyalternativen.
Dessa metoder ska i sin tur använda sig av metoderna Addera och Störst som du
skrev i de två föregående uppgifterna. Du kan kopiera dessa metoder från dina
tidigare program till ditt nya program.*/
