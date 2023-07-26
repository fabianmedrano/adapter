using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    public class BossAdapter: Enemy
    {
        private Boss boss;
        public BossAdapter(Boss boss) {
            this.boss = boss;
        }
        public override void TakeDamage( int damage) { 
            boss.TakeAttack( damage );
        }
    }
}
