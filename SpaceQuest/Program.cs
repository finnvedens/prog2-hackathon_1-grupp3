using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\tWELCOME TO SPACE QUEST");

        Cockpit cockpit = new Cockpit("Cockpit", 4);
        EngineRoom engRoom = new EngineRoom("Engineroom", 6);
        string choice;
        cockpit.instruction();
        choice = Console.ReadLine();
        cockpit.brake(choice);

    }
}

