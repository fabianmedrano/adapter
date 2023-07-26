using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    internal class Program
    {

        /*
        When you want to use an existing class, but its interface does not match the one you need.

        When you want to create a reusable class that cooperates with unrelated or unintended classes, that is, classes that do not necessarily have compatible interfaces.

        When you need to use several existing subclasses, but it is impractical to adapt their interfaces by creating subclasses for each one. An adapter can adapt the interface of its base class.
         */
        static void Main(string[] args)
        {
            Character character = new Character();
            Enemy enemy = new Enemy();
            Boss boss = new Boss();
            BossAdapter bossAdapter = new BossAdapter(boss);

            character.Attack(enemy);
            character.Attack(bossAdapter);
            Console.ReadLine();
        }
    }
}
