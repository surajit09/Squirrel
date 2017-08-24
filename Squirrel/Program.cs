using System;
using System.Collections.Generic;

/*
The weresquirrel

Every now and then, usually between eight and ten in the evening,
Jacques finds himself transforming into a small furry rodent with a bushy
tail.

On one hand, Jacques is quite glad that he doesn’t have classic lycanthropy.
Turning into a squirrel tends to cause fewer problems than
turning into a wolf. Instead of having to worry about accidentally eating
the neighbor (that would be awkward), he worries about being eaten by
the neighbor’s cat. After two occasions where he woke up on a precariously
thin branch in the crown of an oak, naked and disoriented, he has
taken to locking the doors and windows of his room at night and putting
a few walnuts on the floor to keep himself busy.

That takes care of the cat and oak problems. But Jacques still suffers
from his condition. The irregular occurrences of the transformation make
him suspect that they might be triggered by something. For a while, he
believed that it happened only on days when he had touched trees. So
he stopped touching trees entirely and even avoided going near them.
But the problem persisted.

Switching to a more scientific approach, Jacques intends to start keeping
a daily log of everything he did that day and whether he changed
form. With this data he hopes to narrow down the conditions that trigger
the transformations.
*/

/*
Correlation is a measure of dependence between variables ("variables"
in the statistical sense). It is usually expressed as a coefficient that
ranges from -1 to 1. Zero correlation means the variables are not related,
whereas a correlation of one indicates that the two are perfectly related
— if you know one, you also know the other.
Negative one also means that the variables are perfectly related but that
they are opposites — when one is true, the other is false.

Correlation for boolean properties:
phi = (n11 * n00 - n10 * n01) / sqrt(n1X * n0X * nX1 * nX0)

n11 = #(Propery1 = true and Propery2 = true)
n10 = ...
*/

/*
Calculate the correlations between the events and Jacque turning into
a squirrel with the entries in this daily log and reason about them.
*/

namespace Squirrel
{
    internal sealed class Entry
    {
        public bool Squirrel { get; set; }
        public List<string> Events { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var log = Util.LoadEntries();

            Solution.Run(log);

            Console.ReadKey();
        }
    }
}