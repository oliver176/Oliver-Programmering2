using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektOrientering
{
    class Enemy
    {
        public int hp = 100;

        public void Hurt(int amount)
        {
            hp -= amount;

            if (hp < 0)
            {
                hp = 0;
            }
        }
        public void Heal(int amount)
        {
            hp += 1;

            if (hp > 0)
            {
                hp = 100;
            }
        }
        public int Attack()
        {
            int damage;
            Random generator = new Random();
            damage = generator.Next(2, 5);

            return damage;
        }

    }
}
