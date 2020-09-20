using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        public string playerName;
        public int playerHealth;
        public int playerDamage;
        public int playerFear;

        public Player()
        {
            playerHealth = 100;
            playerDamage = 5;
        }

        public Player(string nameVal, int healthVal, int damageVal, int fearVal)
        {
            playerName = nameVal;
            playerHealth = healthVal;
            playerDamage = damageVal;
            playerFear = fearVal;
        }
    }
}
