using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHangman
{
    internal class Hangman
    {
        private string CorrectWord { get; set; }
        private char[] DisplayWord;
        private int MaxGuesses = 10;
        private int WrongGuesses = 0;
        private int RightGuesses;
        private int WinCondition;
        private List<char> GuessedLetters = new List<char>();

        public string SetWord()
        {
            Console.WriteLine("Whats the word?");
            string setWord = Console.ReadLine();

            if (string.IsNullOrEmpty(setWord))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a word...!");
                return "";
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Word SET!");
                return CorrectWord = setWord.ToUpper();
            }
        }

        public void GuessWord()
        {
            //Makes Display word show _ _ _ A _ B
            DisplayWord = new char[CorrectWord.Length];
            for (int i = 0; i < DisplayWord.Length; i++)
            {
                DisplayWord[i] = '_';
            }

            Console.WriteLine($"The word is {CorrectWord.Length} letters long ");
            Console.WriteLine(DisplayWord);
            Thread.Sleep(2000);
            Console.WriteLine("Good luck!");
            Pause();

            while (WrongGuesses < MaxGuesses)
            {
                bool rightGuess = false;
                Console.Clear();
                Console.WriteLine(DisplayWord);
                foreach (char c in GuessedLetters)
                {
                    Console.Write(c + "\n");
                }

                Console.WriteLine("Guess?");
                char guessChar = Convert.ToChar(Console.ReadLine().ToUpper());
                GuessedLetters.Add(guessChar);

                for (int i = 0; i < CorrectWord.Length; i++)
                {
                    if (guessChar == CorrectWord[i])
                    {
                        rightGuess = true;
                        DisplayWord[i] = CorrectWord[i];
                        Console.WriteLine("You found one letter.");
                        Pause();
                    }
                }

                if (!rightGuess)
                {
                    WrongGuesses++;
                    Console.WriteLine("Wrong.");
                    Console.WriteLine($"You have guessed wrong {WrongGuesses} out of {MaxGuesses}");
                    Pause();
                }
            }
            Console.Clear();
            Console.WriteLine("You lose.");
        }

        public string GetWord()
        {
            return CorrectWord;
        }

        public void Pause()
        {
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}