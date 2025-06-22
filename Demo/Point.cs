using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Point
    {
        public int x { get; set; } //= 0; // 4 byte
        public int y { get; set; } //= default(int);// 4 byte
    }
    class Point3D : Point
    {
        public int z { get; set; }  // 4 byte
    }
}
