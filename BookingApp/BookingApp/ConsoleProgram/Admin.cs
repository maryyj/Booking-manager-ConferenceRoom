using BookingApp.ConsoleProgram;
using BookingApp.Data;
using BookingApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookingApp.ConsoleHelpers
{
    enum AdminMenuList
    {
        Visa_alla_konferensrum = 1,
        Lägg_till_rum,
        Ta_bort_rum,
        Ta_bort_bokning,
        Sök_konferensrum,
        Statistik,
        Tillbaka_till_startsidan,
        Avsluta = 9
    }
    public class Admin
    {
        RoomManager room = new();
        User user = new();
        StartMenu startMenu = new();
        StatisticSite statSite = new();
        public void RunProgram()
        {
            bool runProgram = true;

            while (runProgram)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Välkommen Admin!");
                Console.ResetColor();
                Console.WriteLine("Gör ett av följande val:");
                foreach (int i in Enum.GetValues(typeof(AdminMenuList)))
                {
                    Console.WriteLine($"{i}.{Enum.GetName(typeof(AdminMenuList), i).Replace('_', ' ')}");
                }

                int nr;
                AdminMenuList menu = (AdminMenuList)99;
                if (int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out nr))
                {

                    menu = (AdminMenuList)nr;
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
                    case AdminMenuList.Visa_alla_konferensrum:
                        room.GetAllRooms();
                        break;
                    case AdminMenuList.Lägg_till_rum:
                        AddNewRoom();
                        break;
                    case AdminMenuList.Ta_bort_rum:
                        DeleteRoom();
                        break;
                    case AdminMenuList.Ta_bort_bokning:
                        CancelBookedRoom();
                        break;
                    case AdminMenuList.Sök_konferensrum:
                        room.GetSpecificRoom();
                        break;
                    case AdminMenuList.Statistik:
                        statSite.RunProgram();
                        break;
                    case AdminMenuList.Tillbaka_till_startsidan:
                        startMenu.RunProgram();
                        break;

                    case AdminMenuList.Avsluta:
                        runProgram = false;
                        ConsoleTools.QuitProgram();
                        break;
                }
            }
        }

        public void AddNewRoom()
        {
            room.GetAllRooms();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===============================");
            Console.WriteLine("Lägg till ett rum:");
            Console.ResetColor();

            string roomName = ConsoleTools.GetStringFromUser("Ange rumsnamnet :");

            int amountSeats = ConsoleTools.GetIntFromUser("Ange antal sittplatser :");

            int roomSize = ConsoleTools.GetIntFromUser("Ange rummets storlek i kvm:");

            int tvScreenAnswer = ConsoleTools.GetIntFromUser("Finns det TV-skärm i rummet? (1 = ja, 0 = nej): ");
            bool tvScreen = (tvScreenAnswer == 1 ? true : false);

            int whiteboardAnswer = ConsoleTools.GetIntFromUser("Finns det whiteboard tavla? (1 = ja, 0 = nej): ");
            bool whiteBoard = (whiteboardAnswer == 1 ? true : false);

            string description = ConsoleTools.GetStringFromUser("Ange övrig info om rummet (ex. videoutrustning, mörkläggning, kaffemaskin): ");

            using (var myDb = new MyDbContext())
            {
                var newRoom = new Room
                {
                    RoomName = roomName,
                    Seat = amountSeats,
                    RoomSize = roomSize,
                    TVScreen = tvScreen,
                    Whiteboard = whiteBoard,
                    Description = description
                };
                myDb.Add(newRoom);
                myDb.SaveChanges();
            }
        }
        public void DeleteRoom()
        {
            room.GetAllRooms();
            Console.WriteLine("==========================");
            Console.WriteLine();
            using (var myDb = new MyDbContext())
            {
                Console.Write("Ange id på rummet du vill ta bort: ");
                var roomId = Convert.ToInt32(Console.ReadLine());
                var deleteRoom = (from r in myDb.Rooms
                                  where r.Id == (roomId)
                                  select r).SingleOrDefault();
                if (deleteRoom != null)
                {
                    myDb.Rooms.Remove(deleteRoom);
                    myDb.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Id't du angav finns inte.");
                }
            }
        }
        public void CancelBookedRoom()
        {
            int weekChoice = ConsoleTools.GetIntFromUser("Vilken vecka vill du administrera(1-4)? ");
            int dayChoice = ConsoleTools.GetIntFromUser("Vilken veckodag vill du administrera? (1-7)? ");

            if (weekChoice > 0 && weekChoice <= 4 && dayChoice > 0 && dayChoice <= 7)
            {
                user.GetAvailableRoom(weekChoice, dayChoice);
            }
            int roomId = ConsoleTools.GetIntFromUser("Ange Id på rumsbokningen som du vill ta bort: ");
            using (var myDb = new MyDbContext())
            {
                var booking = (from b in myDb.Bookings
                               where b.Week == weekChoice && b.Day == dayChoice && b.Id == roomId
                               select b).SingleOrDefault();

                if (booking.IsAvailable == false)
                {
                    booking.Name = null;
                    booking.WorkTitle = null;
                    booking.IsAvailable = true;
                    myDb.SaveChanges();
                }
            }
        }

        ////Möjlighet att addera rummet man skapat i bookingsidan
        //public void AddNewRoomInBooking()
        //{
        //}
    }
}

