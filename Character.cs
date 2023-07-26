using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    public class Character
    {
        public void Attack(Enemy enemy) {
            enemy.TakeDamage(40);
        }
    }
}
