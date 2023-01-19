using BookingApp.ConsoleHelpers;
using BookingApp.ConsoleProgram;
using BookingApp.Data;

namespace BookingApp
{
    internal class Program
    {
        //Ha helskärm på Console applicationen för bästa resultat
        static void Main(string[] args)
        {
            
            StartMenu sm = new();
            sm.RunProgram();

        }
    }
}