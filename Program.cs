using System;

namespace InterfacesDemo
{
    class Program
    {

        private static Random rnd = new Random ();
        private static int orcLvl = rnd.Next (1, 60);
        private static int elfLvl = rnd.Next (10, 50);

        static void Main(string[] args)
        {
            
            Console.WriteLine("Testing Monsters");
            Elf Nareth = new Elf ("Nareth", elfLvl, 28);
            Orc Brothnagar = new Orc ("Broth'nagar", orcLvl, 8);

            Console.WriteLine ("Elf " + Nareth.Name + " starting level: " + Nareth.Level);
            Console.WriteLine ("Orc " + Brothnagar.Name + " starting level: " + Brothnagar.Level);
            Console.WriteLine ();
            Console.WriteLine ("Elf " + Nareth.Name + " starting health: " + Nareth.Health);
            Console.WriteLine ("Orc " + Brothnagar.Name + " starting health: " + Brothnagar.Health);
            Console.WriteLine ();

            while (Nareth.Health >= 0 && Brothnagar.Health >= 0) {

                if (Nareth.Health > 0) {    
                    Brothnagar.TakeDamage (Nareth.Attack (Brothnagar.Armor));
                
                    Console.WriteLine ("Nareth attacked Broth'Nagar for " + Nareth.Damage + " damage.");
                    Console.WriteLine ("Broth'nagar's health: " + Brothnagar.Health + ", Nareth's health: " + Nareth.Health);
                    Console.WriteLine ();
                }
                if (Brothnagar.Health > 0) {
                    Nareth.TakeDamage (Brothnagar.Attack (Nareth.Armor));

                    Console.WriteLine ("Broth'Nagar attacked Nareth for " + Brothnagar.Damage + " damage.");
                    Console.WriteLine ("Broth'nagar's health: " + Brothnagar.Health + ", Nareth's health: " + Nareth.Health);
                    Console.WriteLine ();
                }
            }

            if (Nareth.Health <= 0) {
                Console.WriteLine ("Brothnagar won!");
            } else if (Brothnagar.Health <= 0) {
                Console.WriteLine ("Nareth won!");
            }
        }
    }
}
