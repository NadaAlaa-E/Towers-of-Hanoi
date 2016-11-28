using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Tower_of_Hanoi
{
    class TowerOfHanoi
    {
        public int num_Discs;
        public Queue<Tuple<int, int>> steps;
        public List<Tower> towers;

        public TowerOfHanoi(int num_Discs)
        {
            this.num_Discs = num_Discs;
            towers = new List<Tower>(3);
            steps = new Queue<Tuple<int, int>>();
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                towers.Add(new Tower());
            }
            for (int i = 0; i < num_Discs; i++)
            {
                Color color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                towers[0].AddDisc(new Disc(num_Discs - i, color));
            }
            solve(num_Discs, 0, 2, 1);
        }

        public void solve(int diskCount, int fromPole, int toPole, int viaPole)
        {
            if (diskCount == 1)
            {
                steps.Enqueue(new Tuple<int, int>(fromPole, toPole));
            }
            else
            {
                solve(diskCount - 1, fromPole, viaPole, toPole);
                solve(1, fromPole, toPole, viaPole);
                solve(diskCount - 1, viaPole, toPole, fromPole);
            }
        }
    }
}
