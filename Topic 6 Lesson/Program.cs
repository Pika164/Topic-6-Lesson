using System.Reflection.Emit;

namespace Topic_6_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Random generator = new Random();
            int max, min;
            Console.Write("Provide me with a maximum value: ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Provide me with a minimum value smaller than the maximum of " + max + ": ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Here is a random number between " + min + " and " + max + ":");
            Console.WriteLine();
            Console.WriteLine(generator.Next(min, max + 1));
            Console.WriteLine();
            Console.WriteLine("Press ENTER to Continue");
            Console.ReadLine();
            Console.Clear();

            //Task 2
            int userGuess, secretNumber;

            secretNumber = generator.Next(1, 10);

            Console.WriteLine("Hello and welcome to upgraded verson of the slightly bad guessing game from topic 5 :). As usual you get one guess to guess the number from 1-10.");
            Console.WriteLine();
            Console.Write("Now, whats you guess of my secret number? ");
            userGuess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (userGuess == secretNumber)
            {
                Console.WriteLine("Yippee! You guessed my random number correct. You must be good at guessing.");
            }
            else
            {
                Console.WriteLine("Sorry but you got it wrong. The random number was " + secretNumber);
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to Continue");
            Console.ReadLine();
            Console.Clear();

            //Task 3 
            int num1, num2, total;

            Console.WriteLine("Hello. Press ENTER to roll the dice.");
            Console.ReadLine();
            num1 = generator.Next(1, 7);
            num2 = generator.Next(1, 7);
            total = num1 + num2;
            Console.WriteLine("Die 1 - " + num1);
            Console.WriteLine("Die 2 - " + num2);
            Console.WriteLine("Total - " + total);
        }
    }
}
