using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> parties = new List<string>();
            int totalGuests = 0;
            string guestComing = "";

            do
            {
                parties.Add(AskInfosFromConsole("What is your party name: "));
                totalGuests += AskNumberOfGuests();
                guestComing = AskInfosFromConsole("Do you want to add guests?(yes/no) ");
            } while (guestComing.ToLower() == "yes");

            Console.WriteLine();
            Console.WriteLine("Guest parties at event");
            foreach (var party in parties)
            {
                Console.WriteLine(party);
            }

            Console.WriteLine();
            Console.WriteLine($"Total guests: {totalGuests}");
            Console.ReadLine();
        }

        private static string AskInfosFromConsole(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();
            return output;

        }

        private static int AskNumberOfGuests()
        {

            bool isValidNumber = false;
            int output = 0;
            do
            {
                string outputText = AskInfosFromConsole("How many people are in your party? ");
                isValidNumber = int.TryParse(outputText, out output);
            } while (isValidNumber == false);
            
            

            return output;
        }
        
    }
}
