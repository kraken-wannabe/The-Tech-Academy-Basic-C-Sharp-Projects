using System;



namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro story text
            Console.WriteLine("ALERT: Pirate raider on intercept vector!");

            // --- shield / incoming hit ---
            Console.WriteLine("Enter your ship's shield rating:");
            int shield = Convert.ToInt32(Console.ReadLine());
            int taken = MathMethods.IncomingHit(shield);
            Console.WriteLine("Impact registered. Hull took " + taken + " damage.");

            // --- repair phase ---
            Console.WriteLine("\nEngineering is on it. Enter your Engineering skill:");
            int engineering = Convert.ToInt32(Console.ReadLine());
            int repaired = MathMethods.RepairHull(engineering);
            Console.WriteLine("Repair drones restored " + repaired + " hull integrity.");

            // --- counter - attack ---
            Console.WriteLine("\nReturn fire! Enter your Attack stat:");
            int attack = Convert.ToInt32(Console.ReadLine());
            int dealt = MathMethods.FireLasers(attack);
            Console.WriteLine("Direct hit! You dealt " + dealt + " damage to the raider.");

            // Exit prompt
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();

        }
    }
}