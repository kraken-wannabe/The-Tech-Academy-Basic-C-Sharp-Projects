using System;


namespace CallingMethodsAssignment
{
    // Three static methods that each take one int and return an int
    public class MathMethods
    {
        // Repair your hull based on ENgineering skill
        public static int RepairHull(int engineering)
        {
            //simple, readable math: more skill => more hull repaired
            int repaired = engineering + 15; // flat bonus of 15
            return repaired;
        }
        //Calculate damage you take after your shield rating absorbs part of it
        public static int IncomingHit(int shield)
        {
            int enemyPower = 12; //enemy attack power is 12
            int variance = 2; //small RNG-like offset
            int crit = 1; //no crits for now
            int damage = (enemyPower + variance - shield) * crit;

            //Never return negative damage; clamp to zero
            if (damage < 0) damage = 0;
            return damage;
        }

        //Your laser volley damage based on Attack stat
        public static int FireLasers(int attack)
        {
            int weaponCore = 9; //ship laser core strength
            int focusBonus = 3; //targeting computer bonus
            int crit = 2; //lucky critical shot x2
            int damage = (attack + weaponCore + focusBonus) * crit;
            return damage;
        }
    }    
}


