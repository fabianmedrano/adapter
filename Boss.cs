using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    public class Boss
    {

        public void TakeAttack(int attack){
            Console.WriteLine($"{attack} attack");
        }
    }
}
