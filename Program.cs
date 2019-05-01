using System;

namespace KnightsOfNalleywey
{
    class Program
    {
        static void Main(string[] args)
        {
            string CharacterName;

            Console.WriteLine("The Knights Of Nallywey");
            Console.WriteLine("\nDeep in the Middlowground Forest sits a four-eyed warlock \nthat has the power to turn lead into gold...\n");
            Console.WriteLine("Enter your knight's name: ");
            CharacterName = Console.ReadLine();
            Console.WriteLine($"Good day Sir {CharacterName}! I'm Sage Kashmir. Pleased to meet you, friend!");
            Console.ReadKey();
        }
    }
}
