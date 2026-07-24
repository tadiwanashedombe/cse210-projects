using System;

class Program
{
    static void Main(string[] args)
    {
        Video _video01 = new Video("My Minimal Samsung Setup in 2026| One UI Done Right", "Paul", 469);
        _video01.AddComment("tadiwa", "This is great");
        _video01.AddComment("tanake", "good setup");
        _video01.AddComment("sean", "this is a great setup");

        Video _video02 = new Video("Jesus Walking on Water", "Jesus", 9069);
        _video02.AddComment("Paul", "This is great");
        _video02.AddComment("Peter", "Can you teach me?");
        _video02.AddComment("Peter", "Im sinking, pls help me");

        Video _video03 = new Video("The Burning Bush","Moses",869);
        _video03.AddComment("Sheep1","Are you seeing this?");
        _video03.AddComment("sheep2","Who started that fire");
        _video03.AddComment("sheep3","i guess we are done");

        Video _video04 = new Video("Sacrificing my son","Abraham",1469);
        _video04.AddComment("Abraham-son","#Hiking with pops");
        _video04.AddComment("Abraham","Faith tested");
        _video04.AddComment("ram","take me instead");

        Video _video05 = new Video("Eden","Adam",9169);
        _video05.AddComment("God","Do not eat from the forbidden tree");
        _video05.AddComment("Adam","ok");
        _video05.AddComment("Eve","Lets eat from the forbidden tree");

        Video.DisplayAll();
    }
}