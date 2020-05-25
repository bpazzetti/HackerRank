using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank.Implementation
{
    class QueensAttackII
    {

        struct Point
        {
            public int c;
            public int r;

            public Point(int c, int r)
            {
                this.c = c;
                this.r = r;
            }
        }

        static void Main1(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] tokens_rQueen = Console.ReadLine().Split(' ');
            Point[] pObstacles = new Point[8];
            for (int i = 0; i < pObstacles.Length; i++)
                pObstacles[i] = new Point(-1, -1);
            int rQueen = Convert.ToInt32(tokens_rQueen[0]);
            int cQueen = Convert.ToInt32(tokens_rQueen[1]);
            int reachableSquares = 0;

            for (int a0 = 0; a0 < k; a0++)
            {
                string[] tokens_rObstacle = Console.ReadLine().Split(' ');
                int rObstacle = Convert.ToInt32(tokens_rObstacle[0]);
                int cObstacle = Convert.ToInt32(tokens_rObstacle[1]);
                //Right
                if ((cObstacle < pObstacles[0].c || pObstacles[0].c == -1) && cObstacle > cQueen && rObstacle == rQueen)
                    pObstacles[0] = new Point(cObstacle, rObstacle);
                //Bottom Right
                if (rQueen - rObstacle == cObstacle - cQueen && cObstacle > cQueen && rObstacle < rQueen
                   && ((rObstacle > pObstacles[1].r && cObstacle < pObstacles[1].c) || pObstacles[1].r == -1))
                    pObstacles[1] = new Point(cObstacle, rObstacle);
                //Bottom
                if ((rObstacle > pObstacles[2].r || pObstacles[2].r == -1) && rObstacle < rQueen && cObstacle == cQueen)
                    pObstacles[2] = new Point(cObstacle, rObstacle);
                //Bottom Left
                if (rQueen - rObstacle == cQueen - cObstacle && cObstacle < cQueen && rObstacle < rQueen
                   && ((rObstacle > pObstacles[3].r && cObstacle > pObstacles[3].c) || pObstacles[3].r == -1))
                    pObstacles[3] = new Point(cObstacle, rObstacle);
                //Left
                if ((cObstacle > pObstacles[4].c || pObstacles[4].c == -1) && cObstacle < cQueen && rObstacle == rQueen)
                    pObstacles[4] = new Point(cObstacle, rObstacle);
                //Top Left
                if (cQueen - cObstacle == rObstacle - rQueen && cObstacle < cQueen && rObstacle > rQueen
                   && ((rObstacle < pObstacles[5].r && cObstacle > pObstacles[5].c) || pObstacles[5].r == -1))
                    pObstacles[5] = new Point(cObstacle, rObstacle);
                //Top
                if ((rObstacle < pObstacles[6].r || pObstacles[6].r == -1) && rObstacle > rQueen && cObstacle == cQueen)
                    pObstacles[6] = new Point(cObstacle, rObstacle);
                //Top Right
                if (rObstacle - rQueen == cObstacle - cQueen && cObstacle > cQueen
                   && rObstacle > rQueen && ((rObstacle < pObstacles[7].r && cObstacle < pObstacles[7].c) || pObstacles[7].r == -1))
                    pObstacles[7] = new Point(cObstacle, rObstacle);
            }

            //Calculates the distance to the closest obstacle in each direction and adds it to reachableSquares
            //R B L T
            reachableSquares += (pObstacles[0].c != -1) ? (pObstacles[0].c - cQueen - 1) : n - cQueen;
            reachableSquares += (pObstacles[2].r != -1) ? (rQueen - pObstacles[2].r - 1) : rQueen - 1;
            reachableSquares += (pObstacles[4].c != -1) ? (cQueen - pObstacles[4].c - 1) : cQueen - 1;
            reachableSquares += (pObstacles[6].r != -1) ? (pObstacles[6].r - rQueen - 1) : n - rQueen;

            //BR BL TL TR
            reachableSquares += (pObstacles[1].c != -1) ? (pObstacles[1].c - cQueen - 1) : Math.Min(n - cQueen, rQueen - 1);
            reachableSquares += (pObstacles[3].r != -1) ? (cQueen - pObstacles[3].c - 1) : Math.Min(cQueen - 1, rQueen - 1);
            reachableSquares += (pObstacles[5].c != -1) ? (cQueen - pObstacles[5].c - 1) : Math.Min(cQueen - 1, n - rQueen);
            reachableSquares += (pObstacles[7].r != -1) ? (pObstacles[7].c - cQueen - 1) : Math.Min(n - cQueen, n - rQueen);

            Console.WriteLine(reachableSquares);
        }
    }
}