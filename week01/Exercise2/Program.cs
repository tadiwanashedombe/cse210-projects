using System;

class Program
{
    static void Main(string[] args)
    {
        string grade = "invalid";

        Console.Write("Enter mark percentage: ");
        int mark = int.Parse(Console.ReadLine());
        
        
        if(mark < 0 && mark < 100){
            Console.WriteLine("Percentage can not be below 0!");
        }
        else if(mark >= 90)
        {
            grade = "A";
        }else if(mark >= 80){
            grade = "B";
        }else if(mark >= 70){
            grade = "C";
        }else if(mark >= 60){
            grade = "D";
        }else if(mark < 60){
            grade = "F";
        }

        // pass 
        if(mark >= 70)
        {
            Console.WriteLine("Congratulations, You passed this course");
        }else
        {
            Console.WriteLine("Failed, Better luck next time.");
        }
        
        Console.WriteLine($"Grade :{grade}");
    }
}