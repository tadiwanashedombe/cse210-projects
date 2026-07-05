using System;

class Program
{
    static void Main(string[] args)
    {

        static void DisplayWelcome()
        {
                   Console.WriteLine("Welcome to the program!");
        }

        DisplayWelcome();

        static string PromptUserName()
        {
            Console.Write("Please enter your name : ");
            string name = Console.ReadLine();

            return name;
        }
        string name  = PromptUserName();

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number : ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }
        int number = PromptUserNumber();

        static int SquareNumber(int num)
        {
            int square  = num*num;

            return square;
        }
        int square = SquareNumber(number);

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

        DisplayResult(name, square);

    }
}