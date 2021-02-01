using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Plane
    {
        public int XSize { get; set; }
        public int YSize { get; set; }
        public Plane(int x, int y)
        {
            this.XSize = x;
            this.YSize = y; 
        }
    }
}
