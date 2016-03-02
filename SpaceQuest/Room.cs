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
        if (life <= 0)
            return life;

        else return life;
    }
}

class Cockpit : Room
{
    public Cockpit(string name, int hzM) : base(name, hzM)
    {
    }
<<<<<<< HEAD

    public void instruction()
    {
        Console.WriteLine("Putin wakes up in the cockpit after being unconsious after being hit by the astroid.");
        Console.WriteLine("He sees that his ship is heading towards Corusant in full speed, he needs to slow down his spaceship.");
        Console.WriteLine("infront of him there are two levers, the right one is the brake and the one to the left is the thruster");
        Console.WriteLine("- Putin Pulls the break lever and the ships speed decreases and he has more time to save the ship.");
        Console.WriteLine("- Putin pulls the thruster lever and nothing happens it appears as the thruster is broken and the ship is still crashing down towards Corusant in the same speed as before.");
    }

=======
    
>>>>>>> origin/master
    public int brake(string choice)
    {
        if (choice == "pull brake")
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
        if (choice == "spit")
        {
            return life -= 10 * hzM;
        }
        else if (choice == "use fire extinguisher")
        {
            return life -= 10 * hzM;
        }
        else if (choice == "use force lightning")
        {
            return life;
        }
        else
        {
            Console.WriteLine("You had one job. Choose one of the three. Time wasted..");
            return life -= 1 * hzM;
        }

    }
}

class EscapePod : Room
{
    EscapePod(string name, int hzM) : base(name, hzM)
    {

    }

    //SKa alltid kunna rymma till escapepod - Game over - Chicken out - Putin överlever - Strippklubb förstörs
    public void eject()
    {
        Console.WriteLine("You bail out, just as a scared bantha cub. No glory was won this day. The stripclub burn down and your mission failed. ");
    }
}
