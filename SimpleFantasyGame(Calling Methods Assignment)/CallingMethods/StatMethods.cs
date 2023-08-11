using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class MathMethods
    {
        public static int Attack(int attack)
        {
            int weapon_pt = 10;
            int enemy_def = 3;
            int special_att = 2;
            int crit_hit = 5;
            int damage = (attack + (weapon_pt + special_att) * crit_hit - enemy_def);
            return damage;
        }
        public static int Defense(int defense)
        {
            int enemy_att = 5;
            int weapon_pt = 4;
            int special_att = -3;
            int crit_hit = 4;
            int damage = (enemy_att + (weapon_pt + special_att) - defense) * crit_hit;
            return damage;
        }
        public static int Prayer(int prayer)

        {
            int health = prayer + 5;
            return health;
        }
    }
}
