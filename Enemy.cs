using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    public class Enemy
    {
        /*
        # virtual

        When you want to allow a derived class to provide a custom implementation of a method, property, indexer or event of the base class.

        When you want to provide a default implementation of a method in a base class, but also allow derived classes to override it if necessary.

        When you want to define a common behavior for a set of related classes in a base class, but also allow each derived class to provide its own custom implementation.
        */
        public virtual void TakeDamage(int damage) { 
            Console.WriteLine($"{damage} damage");
        }

    }
}
