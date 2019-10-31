using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class mypoint
    {
        private int X, Y;
        public mypoint()
        {
            this.X = this.Y = 0;
        }

        public mypoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int GetX() { return this.X; }
        public int GetY() { return this.Y; }

        public void SetX(int x) { this.X = x; }
        public void SetX(int y) { this.Y = y; }

        public int[] GetXY()
        {
            return new int[] { this.X, this.Y };
        }

    }
}
