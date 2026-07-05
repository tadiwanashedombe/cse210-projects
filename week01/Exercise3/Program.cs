using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,11);
        
        int guess = 0;
        int guess_count = 0;

        while(guess != number){
            Console.Write("What is the magic number ? ");
            guess = int.Parse(Console.ReadLine());

            guess_count++;

            if(guess == number)
            {
                Console.WriteLine($"You guessed it !\nYou took {guess_count} guesses.");

            }else if(guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
                
            }
        }
    }
}