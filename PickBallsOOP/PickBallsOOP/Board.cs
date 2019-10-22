using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Board
    {
        private int G1;

        public int G11
        {
            get { return G1; }
            set { G1 = value; }
        }
        private int G2;

        public int G21
        {
            get { return G2; }
            set { G2 = value; }
        }
        private int G3;

        public int G31
        {
            get { return G3; }
            set { G3 = value; }
        }

        public void Pickball(int Group, int b)
        {
            switch (Group)
            {
                case 1:
                    G1 -= b;
                    break;
                case 2:
                    G2 -= b;
                    break;
                case 3:
                    G3 -= b;
                    break;
                default:
                    break;

            }

        }
        public void PrintGame()
        {
            Console.Write("Group 1:");
            for (int i = 0; i < G1; i++)
            {
                Console.Write("o");
            }
            Console.WriteLine();
            Console.Write("Group 2:");
            for (int i = 0; i < G2; i++)
            {
                Console.Write("o");
            }
            Console.WriteLine();
            Console.Write("Group 3:");
            for (int i = 0; i < G3; i++)
            {
                Console.Write("o");
            }
            Console.WriteLine();
        }
        public bool IsGameOver()
        {
            if (G1 == 0 && G2 == 0 && G3 == 0)
                return true;
            return false;
        }
        public Board(int g1, int g2, int g3)
        {
            this.G1 = g1;
            this.G2 = g2;
            this.G3 = g3;
        }
    }
}
