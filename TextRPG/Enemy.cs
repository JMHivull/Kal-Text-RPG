using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Enemy
    {
        public int Health;
        public int Speed;
        public int Strength;

        public Enemy (int Health, int Speed, int Strength)
        {
            this.Health = Health;
            this.Speed = Speed;
            this.Strength = Strength;

        }

        public void Attack ()
        {
            Player.TakeDamage(Strength);
        }

        public void TakeDamage (int damage)
        {
            Random rand = new Random();
            int x = rand.Next(10);

            if (x > Speed)
            {
                Health -= damage;
            }
        }
    }
}
