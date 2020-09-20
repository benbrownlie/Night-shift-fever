using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        Player player;
        bool gameOver = false;

        public Player CreateCharacter()
        {
            Console.WriteLine("Welcome to your first shift at the Latenight convenience store. Can I get your name please?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + "! Please head into the office and clock in.");
            Player player = new Player(name, 100, 5, 0);
            return player;
        }
        //Run the game
        public void Run()
        {
            Start();

            while (gameOver == false)
            {
                Update();
            }

            End();
            
        }

        //Performed once when the game begins
        public void Start()
        {
            CreateCharacter();
        }

        //Repeated until the game ends
        public void Update()
        {
            
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
