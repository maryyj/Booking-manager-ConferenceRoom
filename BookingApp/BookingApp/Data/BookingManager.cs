using BookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BookingApp.Data
{
    public class BookingManager
    {
        //La till veckor och dagar i databasen för att användaren sedan ska kunna skifta mellan veckorna.
        //Finns säkert lättare sätt att göra detta på, men kunde inte se något annat när jag väl börjat.
        public void AddWeeks()
        {
            using (var myDb = new MyDbContext())
            {
                myDb.AddRange(
                 new Booking
                 {
                     Week = 1,
                     Day = 1,
                     RoomId = 1
                 },
                  new Booking
                  {
                      Week = 1,
                      Day = 1,
                      RoomId = 2
                  },
                   new Booking
                   {
                       Week = 1,
                       Day = 1,
                       RoomId = 3
                   },
                 new Booking
                 {
                     Week = 1,
                     Day = 2,
                     RoomId = 1
                 },
                 new Booking
                 {
                     Week = 1,
                     Day = 2,
                     RoomId = 2
                 },
                 new Booking
                 {
                     Week = 1,
                     Day = 2,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 1,
                     Day = 3,
                     RoomId = 1

                 },
                 new Booking
                 {
                     Week = 1,
                     Day = 3,
                     RoomId = 2

                 },

                 new Booking
                 {
                     Week = 1,
                     Day = 3,
                     RoomId = 3

                 },
                 new Booking
                 {
                     Week = 1,
                     Day = 4,
                     RoomId = 1
                 },
                 new Booking
                 {
                     Week = 1,
                     Day = 4,
                     RoomId = 2

                 },

                 new Booking
                 {
                     Week = 1,
                     Day = 4,
                     RoomId = 3

                 },
                 new Booking
                 {
                     Week = 1,
                     Day = 5,
                     RoomId = 1
                 },

                 new Booking
                 {
                     Week = 1,
                     Day = 5,
                     RoomId = 2
                 },

                 new Booking
                 {
                     Week = 1,
                     Day = 5,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 1,
                     Day = 6,
                     RoomId = 1
                 },

                 new Booking
                 {
                     Week = 1,
                     Day = 6,
                     RoomId = 2
                 },

                 new Booking
                 {
                     Week = 1,
                     Day = 6,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 1,
                     Day = 7,
                     RoomId = 1
                 },
                 new Booking
                 {
                     Week = 1,
                     Day = 7,
                     RoomId = 2
                 },
                 new Booking
                 {
                     Week = 1,
                     Day = 7,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 2,
                     Day = 1,
                     RoomId = 1
                 },

                 new Booking
                 {
                     Week = 2,
                     Day = 1,
                     RoomId= 2
                 },

                 new Booking
                 {
                     Week = 2,
                     Day = 1,
                     RoomId= 3
                 },
                 new Booking
                 {
                     Week = 2,
                     Day = 2,
                     RoomId = 1
                 },

                 new Booking
                 {
                     Week = 2,
                     Day = 2,
                     RoomId= 2
                 },

                 new Booking
                 {
                     Week = 2,
                     Day = 2,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 2,
                     Day = 3,
                     RoomId = 1
                 },
                 new Booking
                 {
                     Week = 2,
                     Day = 3,
                     RoomId= 2
                 },
                 new Booking
                 {
                     Week = 2,
                     Day = 3,
                     RoomId= 3
                 },
                 new Booking
                 {
                     Week = 2,
                     Day = 4,
                     RoomId = 1
                 },
                 new Booking
                 {
                     Week = 2,
                     Day = 4,
                     RoomId= 2
                 },
                 new Booking
                 {
                     Week = 2,
                     Day = 4,
                     RoomId= 3
                 },
                 new Booking
                 {
                     Week = 2,
                     Day = 5,
                     RoomId = 1
                 },

                 new Booking
                 {
                     Week = 2,
                     Day = 5,
                     RoomId= 2
                 },

                 new Booking
                 {
                     Week = 2,
                     Day = 5,
                     RoomId= 3
                 },
                 new Booking
                 {
                     Week = 2,
                     Day = 6,
                     RoomId = 1
                 },
                 new Booking
                 {
                     Week = 2,
                     Day = 6,
                     RoomId= 2
                 },
                 new Booking
                 {
                     Week = 2,
                     Day = 6,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 2,
                     Day = 7,
                     RoomId = 1
                 },
                 new Booking
                 {
                     Week = 2,
                     Day = 7,
                     RoomId= 2
                 },
                 new Booking
                 {
                     Week = 2,
                     Day = 7,
                     RoomId= 3
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 1,
                     RoomId = 1
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 1,
                     RoomId= 2
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 1,
                     RoomId= 3
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 2,
                     RoomId = 1
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 2,
                     RoomId = 2

                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 2,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 3,
                     RoomId = 1
                 },

                 new Booking
                 {
                     Week = 3,
                     Day = 3,
                     RoomId = 2
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 3,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 4,
                     RoomId = 1
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 4,
                     RoomId = 2
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 4,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 5,
                     RoomId =1
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 5,
                     RoomId  =2
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 5,
                     RoomId = 3 
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 6,
                     RoomId = 1
                 },

                 new Booking
                 {
                     Week = 3,
                     Day = 6,
                     RoomId = 2
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 6,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 7,
                     RoomId = 1
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 7,
                     RoomId = 2
                 },
                 new Booking
                 {
                     Week = 3,
                     Day = 7,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 1,
                     RoomId= 1
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 1,
                     RoomId = 2
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 1,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 2,
                     RoomId = 1
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 2,
                     RoomId = 2
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 2,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 3,
                     RoomId = 1
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 3,
                     RoomId = 2
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 3,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 4,
                     RoomId = 1
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 4,
                     RoomId = 2
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 4,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 5,
                     RoomId = 1
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 5,
                     RoomId= 2
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 5,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 6,
                     RoomId = 1
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 6,
                     RoomId = 2
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 6,
                     RoomId = 3
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 7,
                     RoomId = 1
                 },

                 new Booking
                 {
                     Week = 4,
                     Day = 7,
                     RoomId = 2
                 },
                 new Booking
                 {
                     Week = 4,
                     Day = 7,
                     RoomId = 3
                 }
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 1,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 1,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 1,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 2,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 2,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 2,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 3,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 3,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 3,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 4,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 4,
                 //    RoomId= 2
                 //}
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 4,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 5,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 5,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 5,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 6,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 6,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 6,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 7,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 7,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 5,
                 //    Day = 7,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 1,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 1,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 1,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 2,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 2,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 2,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 3,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 3,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 3,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 4,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 4,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 4,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 5,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 5,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 5,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 6,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 6,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 6,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 7,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 7,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 6,
                 //    Day = 7,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 1,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 1,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 1,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 2,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 2,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 2,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 3,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 3,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 3,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 4,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 4,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 4,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 5,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 5,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 5,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 6,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 6,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 6,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 7,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 7,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 7,
                 //    Day = 7,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 1,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 1,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 1,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 2,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 2,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 2,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 3,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 3,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 3,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 4,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 4,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 4,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 5,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 5,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 5,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 6,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 6,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 6,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 7,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 7,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 8,
                 //    Day = 7,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 1,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 1,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 1,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 2,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 2,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 2,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 3,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 3,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 3,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 4,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 4,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 4,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 5,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 5,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 5,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 6,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 6,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 6,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 7,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 7,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 9,
                 //    Day = 7,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 1,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 1,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 1,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 2,
                 //    RoomId = 1
                 //},

                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 2,
                 //    RoomId= 2
                 //},

                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 2,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 3,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 3,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 3,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 4,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 4,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 4,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 5,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 5,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 5,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 6,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 6,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 6,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 7,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 7,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 10,
                 //    Day = 7,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 1,
                 //    RoomId= 1
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 1,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 1,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 2,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 2,
                 //    RoomId= 2
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 2,
                 //    RoomId= 3
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 3,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 3,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 3,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 4,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 4,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 4,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 5,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 5,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 5,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 6,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 6,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 6,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 7,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 7,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 11,
                 //    Day = 7,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 1,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 1,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 1,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 2,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 2,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 2,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 3,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 3,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 3,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 4,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 4,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 4,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 5,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 5,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 5,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 6,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 6,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 6,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 7,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 7,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 12,
                 //    Day = 7,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 1,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 1,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 1,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 2,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 2,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 2,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 3,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 3,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 3,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 4,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 4,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 4,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 5,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 5,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 5,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 6,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 6,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 6,
                 //    RoomId = 3
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 7,
                 //    RoomId = 1
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 7,
                 //    RoomId = 2
                 //},
                 //new Booking
                 //{
                 //    Week = 13,
                 //    Day = 7,
                 //    RoomId = 3
                 //}
                 );
               //myDb.SaveChanges();
            }
        }
    }
}
