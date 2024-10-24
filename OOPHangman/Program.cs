namespace OOPHangman
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Hangman word = new Hangman();
            string menuInput = "";

            while (menuInput != "exit")
            {
                Console.Clear();
                Console.WriteLine("Press 1: Set Word");
                Console.WriteLine("Press 2: To Guess word");
                Console.WriteLine("Press 3: To Show word");
                Console.WriteLine("Press exit: To END");
                menuInput = Console.ReadLine();

                if (menuInput == "1")
                {
                    Console.Clear();
                    word.SetWord();
                    Pause();
                }
                if (menuInput == "2")
                {
                    Console.Clear();
                    word.GuessWord();
                    Pause();
                }
                if (menuInput == "3")
                {
                    Console.WriteLine(word.GetWord());
                    Pause();
                }
                if (menuInput == "exit")
                {
                    Console.Clear();
                    Console.WriteLine("Ending...");
                    break;
                }
            }

            void Pause()
            {
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}