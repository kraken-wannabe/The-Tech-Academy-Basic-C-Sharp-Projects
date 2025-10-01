using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassMethodAssignment
{
    public class Class
    {
        //Create three methods that take one int and return an int
        public static int Heal(int magic)
        {
            int hitpoints = magic + 10;
            return hitpoints;
        }
        public static int Defense (int defense)
        {
            int enemy_power = 9;
            int weapon_enemy = 13;
            int weapon_penalty = -3;
            int critical = 3;

            int damage = (enemy_power + (weapon_enemy + weapon_penalty) - defense) * critical; //damage taken
            return damage;
        }
        public static int Attack(int Strength)
        {
            int enemy_def = 7;
            int weapon_def = 8;
            int weapon_bonus = 3;
            int critical_def = 4;

            int damage = (Strength + (weapon_def + weapon_bonus) - enemy_def) * critical_def; //attack damage
            return damage;
        }
    }
}
