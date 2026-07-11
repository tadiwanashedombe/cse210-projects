// added a ShowEntries Function that displays snippets of the actual entry and allows user to select which entry to see
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool journaling = true;

        Console.WriteLine("Welcome to the Journal Program \n");

        while (journaling)
        {
            Console.WriteLine("\nPlease select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Show Entries");
            Console.WriteLine("6. Quit");
            Console.Write("Which option would you like to take? ");

            string action = Console.ReadLine();

            if (action == "1")
            {
                DateTime theCurrentTime = DateTime.Now;
                Entry newEntry = new Entry();
                newEntry._date = theCurrentTime.ToShortDateString();
                newEntry._promptText = promptGenerator.GetRandomPrompt();

                Console.Write($"{newEntry._promptText}\n> ");
                newEntry._entryText = Console.ReadLine();

                journal.AddEntry(newEntry);

            }
            else if (action == "2")
            {
                journal.DisplayAll();
            }
            else if (action == "3")
            {
                Console.Write("Filename : ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (action == "4")
            {
                Console.Write("Enter file name to save with .txt : ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }else if(action == "5")
            {
             journal.ShowEntries();
            }
            else if (action == "6")
            {
                Console.WriteLine("Closing...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice");
                Console.WriteLine("Closing...");
                break;
            }
        }
    }
}