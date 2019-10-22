using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Controller
    {
        private Board game;
        private Player P1, P2;

        public void PlayGame()
        {
            game.PrintGame();
            while (true)
            {
                Console.WriteLine(P1.GetName() + " turn");
                P1.PickBall(game);
                if (game.IsGameOver())
                {
                    Console.WriteLine(P1.GetName() + " loses ");
                    Console.WriteLine(P2.GetName() + " wins ");
                    break;
                }
                game.PrintGame();
                Console.WriteLine(P2.GetName() + "turn");
                P2.PickBall(game);
                if (game.IsGameOver())
                {
                    Console.WriteLine(P1.GetName() + " wins ");
                    Console.WriteLine(P2.GetName() + " loses ");
                    break;
                }
                game.PrintGame();
            }
        }

        public Controller()
        {
            P1 = new Player("hung");
            P2 = new Player("Nhan");
            game = new Board(3, 4, 6);
        }
    }
}
