using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment5._6
{
    class Team : Player, IEnumerable
    {
        public List<Player> players = new List<Player>();

        public IEnumerator GetEnumerator()
        {
            foreach (object o in players)
            {
                yield return o;
            }
        }

        public void AddPlayer(string nam,int r)
        {
            players.Add(new Player(nam, r));
        }
        
        public void Display()
        {
            Console.WriteLine("\nDisplaying Players Details: ");
            foreach (Player p in players)
            {
                Console.WriteLine(p.name + " " + p.runs);
            }
        }



    }
}
