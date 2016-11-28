using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_of_Hanoi
{
    class Tower
    {
        public List<Disc> discs;
        public int length;
        
        public Tower() 
        {
            length = 0; 
            discs = new List<Disc>();
        }
        public void AddDisc(Disc disc)
        {
            if (length >= 1 && discs.ElementAt(length-1).size < disc.size) return;
            length++;
            discs.Add(disc);
        }
        public Disc RemoveDisc()
        {
            Disc disc = discs.ElementAt(length - 1);
            discs.RemoveAt(length - 1);
            length--;
            return disc;
        }
    }
}
