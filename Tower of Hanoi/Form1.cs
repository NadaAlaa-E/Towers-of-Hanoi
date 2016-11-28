using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tower_of_Hanoi
{
    public partial class Form1 : Form
    {
        int num_Discs;
        TowerOfHanoi game;
        private BackgroundWorker _worker = null;

        public Form1()
        {
            InitializeComponent();
        }

        void DrawRods()
        {
            Graphics g = panel1.CreateGraphics();
            SolidBrush myBrush = new SolidBrush(Color.Black);
            int xStep = 100;

            for (int i = 0; i < 3; i++)
            {
                g.FillRectangle(myBrush, new Rectangle(xStep, 0, 10, panel1.Height - 50));
                xStep += 300;
            }

            myBrush.Dispose();
            g.Dispose();
        }

        void DrawDiscs()
        {
            if (game == null) return;

            panel1.Refresh();
            Graphics g = panel1.CreateGraphics();
            int xStep = 100;
            int widthVariance = 200;
            int heightVariance = panel1.Height - 80;

            for (int i = 0; i < game.towers.Count; i++)
            {
                for (int j = 0; j < game.towers[i].discs.Count; j++)
                {
                    int width = (game.towers[i].discs[j].size * widthVariance) / game.num_Discs;
                    int x = xStep - width / 2 + 5;
                    int y = heightVariance - j * 35;
                    g.FillRectangle(new SolidBrush(game.towers[i].discs[j].color), new Rectangle(x, y, width, 30));
                }
                xStep += 300;
            }
        }

        private void numDiscsTxt_TextChanged(object sender, EventArgs e)
        {
            if (numDiscsTxt.Text.Length == 0) return;
            num_Discs = int.Parse(numDiscsTxt.Text);
            game = new TowerOfHanoi(num_Discs);
            DrawDiscs();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawRods();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            _worker = new BackgroundWorker();
            _worker.WorkerSupportsCancellation = true;

            _worker.DoWork += new DoWorkEventHandler((state, args) =>
            {
                do
                {
                    if (_worker.CancellationPending)
                        break;

                    Tuple<int, int> step = game.steps.Dequeue();
                    int fromTower = step.Item1, toTower = step.Item2;
                    Disc disc = game.towers[fromTower].RemoveDisc();
                    game.towers[toTower].AddDisc(disc);
                    DrawDiscs();
                    System.Threading.Thread.Sleep(500);

                } while (game.steps.Count != 0);
                startBtn.Enabled = true;
                stopBtn.Enabled = false;
                numDiscsTxt.Enabled = true;
            });
            _worker.RunWorkerAsync();
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
            numDiscsTxt.Enabled = false;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            stopBtn.Enabled = false;
            startBtn.Enabled = true;
            numDiscsTxt.Enabled = true;
            _worker.CancelAsync();
        }
    }
}
