using System;

class Program
{
    static void Main(string[] args)
    {
        bool add_number = true;
        int number;
        List<int> numbers = new List<int>();

        while(add_number)
        {
            Console.Write("Enter Number : ");
            number = int.Parse(Console.ReadLine());

            if(number == 0)
            {
                add_number = false;
            }
            else
            {
                numbers.Add(number);
            }
        }
        int total = 0;
        int largest = 0;

        foreach(int num in numbers)
        {   if(num > largest)
            {
                largest = num;
            }
            total = num + total;
        }

        Console.WriteLine($"The sum is: {total}");
        
        double avg = numbers.Average();
        Console.WriteLine($"The average is: {avg}");

        Console.WriteLine($"The largest number is: {largest}");

    }
}