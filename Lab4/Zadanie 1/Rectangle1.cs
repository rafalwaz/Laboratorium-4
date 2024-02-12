using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangle1 : Shape
    {

        public override void Draw()
        {
            base.Draw();
            Console.Write(Name + "\n");
            Console.WriteLine($"O współrzednych ({X}, {Y}), " +
                $"o boku a {Width} i b {Height}");
        }
    }
}
