using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjectVP
{
    [Serializable]
    public class Rectangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Color Color { get; set; }
        public bool isSquereColided;

        public Rectangle(Color color)
        {
            isSquereColided = false;
            Color = color;
        }

        public void Draw(Graphics g)
        {
            SolidBrush b = new SolidBrush( Color);
            g.FillRectangle(b, X, Y, Width, Height);
        }
        
    }
}
