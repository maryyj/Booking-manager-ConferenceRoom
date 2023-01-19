using BookingApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Data
{
    public class RoomManager
    {
        public void AddRoom()
        {
            //Hårdkodade för att inte behöva lägga in varje rum med admin (men det är möjligt att göra via admin).
            // 3 nya rum
            using (var myDb = new MyDbContext())
            {
                myDb.AddRange(
                    new Room
                    {
                        RoomName = "Öppenhet",
                        Seat = 15,
                        RoomSize = 50,
                        TVScreen = true,
                        Whiteboard = true,
                        Description = "Hel videokonferensutrustning, mörkläggning, kaffemaskin"
                    },
                    new Room
                    {
                        RoomName = "Tillit",
                        Seat = 10,
                        RoomSize = 30,
                        TVScreen = true,
                        Whiteboard = true,
                        Description = "Hel videokonferensutrustning, mörkläggning"
                    },
                    new Room
                    {
                        RoomName = "Sammarbete",
                        Seat = 6,
                        RoomSize = 18,
                        TVScreen = true,
                        Whiteboard = true,
                        Description = "Hel videokonferensutrustning, mörkläggning"
                    }
                    );
                myDb.SaveChanges();
            }

        }
        public void GetAllRooms()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Konferensrum:");
            Console.ResetColor();
            Console.WriteLine("======================");

            using (var myDb = new MyDbContext())
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Id   Rumsnamn\tSittplatser\tRumsstorlek(kvm)\tTV-Skärm\tWhiteboard\tFaciliteter ");
                Console.ResetColor();
                foreach (var room in myDb.Rooms.Select(d => d))
                {
                    Console.WriteLine($"{room.Id}    {room.RoomName}\t   {room.Seat}\t\t  {room.RoomSize}\t\t\t" +
                                      $"{(room.TVScreen == true ? "Ja" : "Nej")}\t\t" +
                                      $"{(room.Whiteboard == true ? "Ja" : "Nej")}\t\t {room.Description}\n");
                }
            }
        }
        public void GetSpecificRoom()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var answer = ConsoleTools.GetStringFromUser("Ange vad du söker: ");
            Console.ResetColor();
            using (var myDb = new MyDbContext())
            {
                var result = from b in myDb.Rooms
                             where b.Description.Contains(answer) || b.RoomName.Contains(answer)
                             select b;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Id   Rumsnamn\tSittplatser\tRumsstorlek(kvm)\tTV-Skärm\tWhiteboard\tFaciliteter ");
                Console.ResetColor();
                foreach (var room in result)
                {
                    Console.WriteLine($"{room.Id}    {room.RoomName}\t   {room.Seat}\t\t  {room.RoomSize}\t\t\t" +
                                      $"{(room.TVScreen == true ? "Ja" : "Nej")}\t\t" +
                                      $"{(room.Whiteboard == true ? "Ja" : "Nej")}\t\t {room.Description}\n");
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

