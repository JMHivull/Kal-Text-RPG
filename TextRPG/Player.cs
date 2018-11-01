using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public static class Player
    {
        public static int Health = 10;
        public static int Speed = 1;
        public static int Strength = 1;

        public static void TakeDamage(int damage)
        {
            Random rand = new Random();
            int x = rand.Next(10);

            if (x > Speed)
            {
                Health -= damage;
            }
        }
        public static void Attack(Enemy L1)
        {
            L1.TakeDamage(Strength);
        }

        public static void Inventory()
        {

        }
    }
}
