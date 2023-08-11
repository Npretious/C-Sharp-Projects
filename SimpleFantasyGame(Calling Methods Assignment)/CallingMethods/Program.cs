using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ouch! The Hell Warrior spikes you with a spell from the underworld!");
            Console.WriteLine("Please enter your defense stat:");
            int defense = Convert.ToInt32(Console.ReadLine());
            int enemy_damage = MathMethods.Defense(defense);
            Console.WriteLine("Dreadfully, you've taken " + enemy_damage + " damage points.");
            Console.WriteLine("You instantly cast your prayer spells to heal.");
            Console.WriteLine("Please enter your prayer stat:");
            int prayer = Convert.ToInt32(Console.ReadLine());
            int health = MathMethods.Prayer(prayer);
            Console.WriteLine("You've been healed for " + health + " health points.");
            Console.WriteLine("Now, plan your counter attack.");
            Console.WriteLine("Please enter your attack stat:");
            int strength = Convert.ToInt32(Console.ReadLine());
            int damage = MathMethods.Attack(strength);
            Console.WriteLine("You landed a significant shot and dealt " + damage + " damage points.");
            Console.WriteLine("The Hell Warriors returns to the underworld after your fatal attack!");
            Console.ReadLine();
        }
    }
}
