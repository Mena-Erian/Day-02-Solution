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

        public override string ToString()
        {
            //return base.ToString();  //Demo.Point
            return $"(X = {this.x},Y = {this.y})";
        }
        public override bool Equals(object? obj)
        {
            //return base.Equals(obj); 
            Point? other = (Point?)obj;
            return this.x == other?.x && this.y == other?.y ;
        }
        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return HashCode.Combine(this.x, this.y);
        }
    }
    class Point3D : Point
    {
        public int z { get; set; }  // 4 byte
        public void printGenaric<T>(T item)
        {
            Console.WriteLine(item);
        }
        public void printObj(Object item)
        {
            Console.WriteLine(item);
        }
    }
}
