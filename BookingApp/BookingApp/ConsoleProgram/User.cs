using BookingApp.Data;
using BookingApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.ConsoleHelpers
{
    enum UserMenuList
    {
        Visa_alla_konferensrum = 1,
        Sök_konferensrum,
        Visa_och_boka_lediga_konferensrum,
        Avsluta = 9
    }
    enum OptionsMenu
    {
        Boka_konferensrum = 1,
        Ändra_vecka_och_dag,
        Tillbaka_till_huvudmenyn,
        Avsluta = 9
    }
    public class User
    {
        RoomManager room = new();

        public void RunProgram()
        {
            bool runProgram = true;
            while (runProgram)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Gör ett av följande val:\n");
                Console.ResetColor();
                foreach (int i in Enum.GetValues(typeof(UserMenuList)))
                {
                    Console.WriteLine($"{i}.{Enum.GetName(typeof(UserMenuList), i).Replace('_', ' ')}");
                }

                int nr;
                UserMenuList menu = (UserMenuList)99; //Default
                if (int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out nr))
                {
                    menu = (UserMenuList)nr;
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel inmatning");
                    Console.ResetColor();
                }

                switch (menu)
                {
                    case UserMenuList.Visa_alla_konferensrum:
                        room.GetAllRooms();
                        break;
                    case UserMenuList.Visa_och_boka_lediga_konferensrum:
                        int weekChoice = ConsoleTools.GetIntFromUser("Vilken vecka vill du boka(1-4)? ");
                        int dayChoice = ConsoleTools.GetIntFromUser("Vilken veckodag vill du boka? (1-7)? ");
                        if (weekChoice > 0 && weekChoice <= 4 && dayChoice > 0 && dayChoice <= 7)
                        {
                            GetAvailableRoom(weekChoice, dayChoice);
                            BookRoomOptions(weekChoice, dayChoice);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Felaktigt värde.");
                            Console.ResetColor();
                        }
                        break;
                    case UserMenuList.Avsluta:
                        runProgram = false;
                        ConsoleTools.QuitProgram();
                        break;
                }
            }
        }

        public void BookRoomOptions(int weekChoice, int dayChoice)
        {
            bool runProgram = true;

            while (runProgram)
            {
                foreach (int i in Enum.GetValues(typeof(OptionsMenu)))
                {
                    Console.WriteLine($"{i}.{Enum.GetName(typeof(OptionsMenu), i).Replace('_', ' ')}");
                }

                int nr;
                OptionsMenu menu = (OptionsMenu)99;
                if (int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out nr))
                {
                    menu = (OptionsMenu)nr;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Fel inmatning");
                }

                switch (menu)
                {
                    case OptionsMenu.Boka_konferensrum:
                        GetAvailableRoom(weekChoice, dayChoice);
                        BookRoom(weekChoice, dayChoice);
                        break;
                    case OptionsMenu.Ändra_vecka_och_dag:

                        int newWeek = ConsoleTools.GetIntFromUser("Ange ny vecka (1-4): ");
                        dayChoice = ConsoleTools.GetIntFromUser("Vilken dag vill du boka? (1-7)? ");

                        if (weekChoice > 0 && weekChoice <= 4 && dayChoice > 0 && dayChoice <= 7)
                        {
                            GetAvailableRoom(newWeek, dayChoice);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Felaktigt värde.");
                            Console.ResetColor();
                        }
                        break;
                    case OptionsMenu.Tillbaka_till_huvudmenyn:
                        RunProgram();
                        break;
                    case OptionsMenu.Avsluta:
                        runProgram = false;
                        ConsoleTools.QuitProgram();
                        break;
                }
            }
        }
        public void GetAvailableRoom(int weekChoice, int dayChoice)
        {
            using (var myDb = new MyDbContext())
            {
                var week = (from w in myDb.Bookings.ToList()
                            join room in myDb.Rooms on w.RoomId equals room.Id
                            where w.Week == weekChoice && w.Day == dayChoice
                            select w);

                Console.WriteLine();
                Console.WriteLine($"Vecka: {weekChoice}");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Dag\t\t   Rumsnamn \t\tId/namn");
                Console.ResetColor();
                foreach (var room in week)
                {
                    Console.Write($"{(room.Day == 1 ? "Måndag" : null)}" +
                                     $"{(room.Day == 2 ? "Tisdag" : null)}" +
                                     $"{(room.Day == 3 ? "Onsdag" : null)}" +
                                     $"{(room.Day == 4 ? "Torsdag" : null)}" +
                                     $"{(room.Day == 5 ? "Fredag" : null)}" +
                                     $"{(room.Day == 6 ? "Lördag" : null)}" +
                                     $"{(room.Day == 7 ? "Söndag" : null)}");

                    Console.Write($"\t\t   {room.Room.RoomName}" +
                                $"\t\t {(room.IsAvailable != true ? "[" + room.Id + "]" + room.Name : "[" + room.Id + "] Ledigt")}\n");

                    Console.WriteLine();
                }
            }
        }
        public void BookRoom(int weekChoice, int dayChoice)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Ange följande:");
            Console.ResetColor();
            int roomId = ConsoleTools.GetIntFromUser("Id på rummet: ");
            string name = ConsoleTools.GetStringFromUser("För- och efternamn ");
            string workTitle = ConsoleTools.GetStringFromUser("Jobbtitel/avdelning: ");

            Console.WriteLine("=============================================");
            Console.WriteLine();
            using (var myDb = new MyDbContext())
            {
                var booking = (from b in myDb.Bookings
                               where b.Week == weekChoice && b.Day == dayChoice && b.Id == roomId
                               select b).SingleOrDefault();
                if (booking != null)
                {
                    booking.Name = name;
                    booking.WorkTitle = workTitle;
                    booking.IsAvailable = false;
                    myDb.SaveChanges();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Upptaget eller ej giltigt, vänligen välj en annan dag.");
                    Console.ResetColor();
                }

            }

        }
    }
}
