using BookingApp.ConsoleHelpers;
using BookingApp.Migrations;
using BookingApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.ConsoleProgram
{
    public class StatisticSite
    {
        enum StatisticMenuList
        {
            Person_med_flest_bokningar = 1,
            Arbetstitel_med_flest_bokningar,
            Populäraste_rummet,
            Tillbaka_till_admin_huvudmeny,
            Avsluta = 9
        }
        public void RunProgram()
        {
            bool runProgram = true;

            while (runProgram)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Statistik");
                Console.WriteLine("=============================");
                Console.ResetColor();
                Console.WriteLine("Gör ett av följande val:");
                foreach (int i in Enum.GetValues(typeof(StatisticMenuList)))
                {
                    Console.WriteLine($"{i}.{Enum.GetName(typeof(StatisticMenuList), i).Replace('_', ' ')}");
                }

                int nr;
                StatisticMenuList menu = (StatisticMenuList)99;
                if (int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out nr))
                {

                    menu = (StatisticMenuList)nr;
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
                    case StatisticMenuList.Person_med_flest_bokningar:
                        GetMostFrequentUser();
                        break;
                    case StatisticMenuList.Arbetstitel_med_flest_bokningar:
                        GetBookedWorkTitles();
                        break;
                    case StatisticMenuList.Populäraste_rummet:
                        GetMostPopularRoom();
                        break;
                    case StatisticMenuList.Tillbaka_till_admin_huvudmeny:
                        Admin admin = new();
                        admin.RunProgram();
                        break;
                    case StatisticMenuList.Avsluta:
                        runProgram = false;
                        ConsoleTools.QuitProgram();
                        break;
                }
            }
        }

        public void GetMostFrequentUser()
        {

            using (var myDb = new MyDbContext())
            {

                var frequentUser = from user in myDb.Bookings
                                   where user.Name != null
                                   group user by user.Name into userName
                                   orderby userName.Count() descending
                                   select new
                                   {
                                       UserName = userName.Key,
                                       NameCount = userName.Count()
                                   };

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("För- och efternamn \t\t Antal bokningar");
                Console.ResetColor();
                foreach (var i in frequentUser)
                {
                    Console.WriteLine($"{i.UserName} \t\t\t\t {i.NameCount}\n");
                }

            }
        }
        public void GetBookedWorkTitles()
        {
            using (var myDb = new MyDbContext())
            {

                var frequentWorktitle = from user in myDb.Bookings
                                        where user.Name != null
                                        group user by user.WorkTitle into workTitle
                                        orderby workTitle.Count() descending
                                        select new
                                        {
                                            WorkTitle = workTitle.Key,
                                            WorkCount = workTitle.Count()
                                        };

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Arbetstitel \t\t Antal bokningar");
                Console.ResetColor();
                foreach (var i in frequentWorktitle)
                {
                    Console.WriteLine($"{i.WorkTitle} \t\t\t {i.WorkCount}\n");
                }
            }

        }
        public void GetMostPopularRoom()
        {
            using (var myDb = new MyDbContext())
            {
                var popularRoom = from b in myDb.Bookings
                                  where b.Name != null
                                  group b by b.RoomId into room
                                  orderby room.Count() descending
                                  select new
                                  {
                                      RoomId = room.Key,
                                      RoomCount = room.Count()
                                  };
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("RumsId \t\t Antal bokningar");
                Console.ResetColor();

                foreach (var room in popularRoom)
                {
                    Console.WriteLine($"{room.RoomId} \t\t\t\t {room.RoomCount}\n");
                }
            }
        }
    }
}
