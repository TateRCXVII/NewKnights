using System;
namespace KnightsOfNalleywey
{
    public class Game
    {
        //Character's name
        private string characterName;
        private const ConsoleColor CHAR_COLOR = ConsoleColor.DarkMagenta;


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
            Dialogue("What do you call yourself? ", ConsoleColor.DarkCyan);
            Console.ForegroundColor = CHAR_COLOR;
            SetCharacterName(Console.ReadLine());
            Console.ResetColor();
        }
        //Game start text sequence
        public void StartGame()
        {
            Console.Title = "The Knights of Nalleywey";
            Console.WriteLine("The Knights Of Nallywey");
            Console.WriteLine("\nDeep in the Middlowground Forest sits a four-eyed warlock \nthat has the power to turn lead into gold...\n");
            this.AskName();
            Dialogue($"Good day Sir ", ConsoleColor.DarkCyan);
            UserDialogue(this.characterName);
            Dialogue("! I'm Sage Kashmir. Pleased to meet you, friend!", ConsoleColor.DarkCyan);
            Console.ReadKey();
        }

        //uncolored dialogue
        public void Dialogue(string dialogue)
        {
            Console.Write(dialogue);
        }

        //colored dialogue
        public void Dialogue(string dialogue, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(dialogue);
            Console.ResetColor();
        }

        public void UserDialogue(string dialogue)
        {
            Console.ForegroundColor = CHAR_COLOR;
            Console.Write(dialogue);
            Console.ResetColor();
        }
    }
}
