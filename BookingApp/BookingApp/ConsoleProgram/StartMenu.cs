using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.ConsoleHelpers
{
    public class StartMenu
    {
        enum MenuList
        {
            Logga_in_som_användare = 1,
            Logga_in_som_admin,
            Avsluta = 9
        }
        public void RunProgram()
        {
            Admin admin = new();
            User user = new();

            bool runProgram = true;
            while (runProgram)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Välkommen!");
                Console.ResetColor();
                Console.WriteLine("Gör ett av följande val:");
                foreach (int i in Enum.GetValues(typeof(MenuList)))
                {
                    Console.WriteLine($"{i}.{Enum.GetName(typeof(MenuList), i).Replace('_', ' ')}");
                }

                int nr;
                MenuList menu = (MenuList)99; 
                if (int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out nr))
                {

                    menu = (MenuList)nr;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Fel inmatning");
                }


                switch (menu)
                {
                    case MenuList.Logga_in_som_användare:
                        user.RunProgram();
                        break;
                    case MenuList.Logga_in_som_admin:
                        admin.RunProgram();
                        break;
                    case MenuList.Avsluta:
                        runProgram = false;
                        ConsoleTools.QuitProgram();
                        break;
                }
            }
        }
    }
}
