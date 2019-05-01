using System;
namespace KnightsOfNalleywey
{
    public class Game
    {
        //Character's name
        private string characterName;

        public Game()
        {
        }

        //Set's the character's name
        public void SetCharacterName(string _characterName)
        {
            this.characterName = _characterName;
        }

        //Game start text sequence
        public void StartGame()
        {
            Console.WriteLine("The Knights Of Nallywey");
            Console.WriteLine("\nDeep in the Middlowground Forest sits a four-eyed warlock \nthat has the power to turn lead into gold...\n");
            Console.WriteLine("Enter your knight's name: ");
            SetCharacterName(Console.ReadLine());
            Console.WriteLine($"Good day Sir {characterName}! I'm Sage Kashmir. Pleased to meet you, friend!");
            Console.ReadKey();
        }
    }
}
