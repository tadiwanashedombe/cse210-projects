// Added LoadFromFile that selects a verser randomly from a txt file
using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = Scripture.LoadFromFile();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            Console.WriteLine("\nPress enter to continue or type 'quit' to exit program");

            string instruction = Console.ReadLine();
            if(instruction.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(2);
        }
    }
}