using System;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        Person p2 = new Person("Jane", "Doe"); 
        Person p3 = new Person("Mrs.", "Jane", "Doe");

        Console.WriteLine(p2.GetFirstName());
    }
}

