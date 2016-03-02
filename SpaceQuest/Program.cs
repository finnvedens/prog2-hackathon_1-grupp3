using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\tWELCOME TO SPACE QUEST");
        Console.WriteLine("Help Putin reach the strip club safe. Land the speceship and enjoy the evening.");
        Console.WriteLine("Press enter to play game.");
        Console.ReadKey();

        Cockpit cockpit = new Cockpit("Cockpit", 4);
        EngineRoom engRoom = new EngineRoom("Engineroom", 6);
        string choice;
        cockpit.instruction();
        choice = Console.ReadLine();
        cockpit.brake(choice);

    }
}

