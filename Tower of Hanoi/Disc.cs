using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tower_of_Hanoi
{
    class Disc
    {
        public int size;
        public Color color; 
        public Disc(int size, Color color)
        {
            this.size = size;
            this.color = color;
        }
    }
}
