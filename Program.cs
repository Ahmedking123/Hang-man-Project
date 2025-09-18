using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Text;
using static System.Random;
namespace HangManGame
{

    internal class Program
    {
        static int Wrong = 0;
        static void PrintHangMan(int wrong)
        {
            if (wrong == 0)
            {
                Console.WriteLine();
                Console.WriteLine("_____\n  |  \n  |  \n === ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

            }
            if (wrong == 1)
            {
                Console.WriteLine();
                Console.WriteLine("_____\n  |  \n  |  \n === ");
                Console.WriteLine("  O  ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            if (wrong == 2)
            {
                Console.WriteLine();
                Console.WriteLine("_____\n  |  \n  |  \n === ");
                Console.WriteLine("  O  ");
                Console.Write("/ ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

            }
            if (wrong == 3)
            {
                Console.WriteLine();
                Console.WriteLine("_____\n  |  \n  |  \n === ");
                Console.WriteLine("  O  ");
                Console.Write("/ ");
                Console.Write("|");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            if (wrong == 4)
            {
                Console.WriteLine();
                Console.WriteLine("_____\n  |  \n  |  \n === ");
                Console.WriteLine("  O  ");
                Console.Write("/ ");
                Console.Write("| ");
                Console.Write(@"\");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            if (wrong == 5)
            {
                Console.WriteLine();
                Console.WriteLine("_____\n  |  \n  |  \n === ");
                Console.WriteLine("  O  ");
                Console.Write("/ ");
                Console.Write("| ");
                Console.WriteLine(@"\");
                Console.Write(" / ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();


            }
            if (wrong == 6)
            {
                Console.WriteLine();
                Console.WriteLine("_____\n  |  \n  |  \n === ");
                Console.WriteLine("  O  ");
                Console.Write("/ ");
                Console.Write("| ");
                Console.Write(@"\");
                Console.WriteLine();
                Console.Write(" / ");
                Console.Write(@"\");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        static int PrintWord(List<char> GuessedCharacters, string GuessedWord)
        {
            int counter = 0;
            int rightCharacters = 0;

            foreach (var c in GuessedWord)
            {
                if (GuessedCharacters.Contains(c))
                {
                    Console.Write(c + " ");
                    rightCharacters++;
                }
                else
                {
                    Console.Write("  ");
                }
                counter++;
            }
            return rightCharacters;
        }
        static void PrintLine(string randomWord)
        {
            foreach (var item in randomWord)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.Write("\u0305  ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("= Welcome to hangman Game =");
            Console.WriteLine("===========================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("To start the game press any key");
            Console.WriteLine("-------------------------------");
            Console.ReadKey();

            Random rnd = new Random();
            List<String> RandomWords = new List<String> { "flower", "sheep", "shape", "butterfly", "butter", "slide", "character", "glide", "grown", "glad", "purfey", "start", "stand" };
            string randomWord = RandomWords[rnd.Next(0, RandomWords.Count)];

            List<char> GuessedCharacters = new List<char>();
            int CorrectGuessedWord = 0;
            Console.Clear();
         
            Console.WriteLine();
            Console.WriteLine();
            while (CorrectGuessedWord < randomWord.Length && Wrong < 6)
            {
                Console.Write("Guessed letters so far: ");
                foreach (var le in GuessedCharacters)
                {
                    Console.Write(le + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Guess a letter: ");
                char letter = Console.ReadLine()[0];



                if (GuessedCharacters.Contains(letter))
                {
                    Console.WriteLine("Already a guessed character");
                   
                }
                else
                {
                    bool right = false;
                    if (randomWord.Contains(letter))
                    {
                        right = true;
                    }
                    if (right)
                    {
                        GuessedCharacters.Add(letter);
                       

                    }
                    else
                    {
                       
                        Wrong++;
                        GuessedCharacters.Add(letter);


                    }
                }
                PrintHangMan(Wrong);
                CorrectGuessedWord = PrintWord(GuessedCharacters, randomWord);
                Console.WriteLine();
                Console.WriteLine();
                PrintLine(randomWord);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            if (Wrong == 6)
            {
                Console.WriteLine("You lost the word is " + randomWord);
            }
            else
            {
                Console.WriteLine("Thanks for playing the game");
            }
            
        }
    }
}

