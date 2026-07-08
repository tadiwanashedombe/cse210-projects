using System;

class Program
{
    static void Main(string[] args)
    {
     
        House johnsonHome = new House();
        johnsonHome._kitchen = new Blind();
        johnsonHome._livingRoom = new Blind();

        johnsonHome._owner = "Johnson Family";

        johnsonHome._kitchen._width = 60;
        johnsonHome._kitchen._height = 48;
        johnsonHome._kitchen._color = "white";
        double kitchenMaterial = johnsonHome._kitchen.GetArea();

        johnsonHome._livingRoom._width = 72;
        johnsonHome._livingRoom._height = 52;
        johnsonHome._livingRoom._color = "white";
        double livingRoomMaterial = johnsonHome._livingRoom.GetArea();

        Console.WriteLine(livingRoomMaterial);
        
            
    }
}
    
