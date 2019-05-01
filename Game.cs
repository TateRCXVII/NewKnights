using System;
namespace KnightsOfNalleywey
{
    public class Game
    {
        //Character's name
        private string characterName;

        public Game()
        {
            characterName = "";
        }

        //Set's the character's name
        public void SetCharacterName(string _characterName)
        {
            this.characterName = _characterName;
        }

        //Asks for the characters name from the user
        private void AskName()
        {
            Console.Write("Enter your knight's name: ");
            SetCharacterName(Console.ReadLine());
        }
        //Game start text sequence
        public void StartGame()
        {
            Console.WriteLine("The Knights Of Nallywey");
            Console.WriteLine("\nDeep in the Middlowground Forest sits a four-eyed warlock \nthat has the power to turn lead into gold...\n");
            this.AskName();
            Console.WriteLine($"Good day Sir {this.characterName}! I'm Sage Kashmir. Pleased to meet you, friend!");
            Console.ReadKey();
        }

        public void Dialogue(string dialogue, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(dialogue);
            Console.ResetColor();
        }
    }
}
