using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp
{
    internal class ConsoleTools
    {
        public static string GetStringFromUser(string text)
        {
            Console.Write(text);
            string result = Console.ReadLine();
            return result;
        }
        public static int GetIntFromUser(string text)
        {
            bool isValid = true;
            int result;
            do
            {
                if (!isValid)
                {
                    Console.WriteLine("Felaktigt värde, prova igen.");
                }
                else isValid = false;

                Console.Write(text);
            } while (!int.TryParse(Console.ReadLine(), out result));

            return result;
        }
        public static void QuitProgram()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Tack för att du använder vår tjänst, välkommen åter!");
            Console.ResetColor();
            Console.ReadKey(true);
            Environment.Exit(0);
        }
    }
}
