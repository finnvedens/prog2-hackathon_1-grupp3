using System;
class Room
{
    private string name;
    //Hazard multiplier
    protected int hzM;
    protected int life = 100;

    public Room(string name, int hzM)
    {
        this.name = name;
        this.hzM = hzM;
    }
    //Funktion för att returnera hur mycket liv spelaren har
    virtual public int die()
    {
        return life;
    }
}

class Cockpit : Room
{
    public Cockpit(string name, int hzM) : base(name, hzM)
    {
    }
    
    public int brake(string choice)
    {
        if(choice == "pull brake")
        {
            Console.WriteLine("Success");
            return life;
        }
        //Om spelaren gör fel val minskar livet med rummets hzM som faktor
        else
        {
            return life -= 10 * hzM;
        }
    }
}

class EngineRoom : Room
{
    public EngineRoom(string name, int hzM) : base(name, hzM)
    {
    }

    public int fire(string choice)
    {
        if(choice == "spit")
        {
            return life -= 10 * hzM;
        }
        else if(choice == "use fire extinguisher")
        {
            return life -= 10 * hzM;
        }
        else if(choice == "use force lightning")
        {
            return life;
        }
        else
        {
            Console.WriteLine("You had one job. Choose one of the three. Time wasted..");
            return life -= 1;
        }

    }
}

//class EscapePod : Room

    //SKa alltid kunna rymma till escapepod - Game over - Chicken out - Putin överlever - Strippklubb förstörs

