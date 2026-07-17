using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs",27,16,18);
        string text = ("Whosoever hideth her hideth the wind, and the ointment of his right hand, which bewrayeth itself.Iron sharpeneth iron; so a man sharpeneth the countenance of his friend.18 Whoso keepeth the fig tree shall eat the fruit thereof: so he that waiteth on his master shall be honoured.");

        Scripture scripture = new Scripture(reference,text);

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