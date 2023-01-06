using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTestDemo
{
    public class Player
    {
    
        public bool isNoob { get; set; }
        public string nickName { get; set; }
        public int health { get; set; }
        public string fullName { get; set; }

        public Player()
        {
            isNoob = true;
            nickName = null;
            health = 100;
            fullName = "Donald Sahu";
        }
        public void newPlayer()
        {
            Console.WriteLine("isNoob: "+ isNoob);
        }

    }
}
