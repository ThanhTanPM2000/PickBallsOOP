using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Player
    {
        private string Name;

        public void PickBall(Board game)
        {
            while (true)
            {
                Console.WriteLine("which Group do you want to choose : ");
                int GroupChoosed = Int32.Parse(Console.ReadLine());
                Console.WriteLine("How many Balls do you want to pick : ");
                int BallsPick = Int32.Parse(Console.ReadLine());
                game.Pickball(GroupChoosed, BallsPick);
                return;
            }
        }

        public Player(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
