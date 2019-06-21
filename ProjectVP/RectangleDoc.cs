using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ProjectVP
{
    [Serializable]
    public class RectangleDoc
    {
      
        public List<Rectangle> rectangles { get; set; }
        Random random;
        
        public RectangleDoc()
        {
            rectangles = new List<Rectangle>();
            random = new Random();
            StaticRectangles();
        }
        public void AddRectangle(Rectangle r)
        {
            rectangles.Add(r);
        }
        public void StaticRectangles ()
        {
            Rectangle r = new Rectangle(Color.Red);
            r.X = 20; r.Y = 60; r.Width = 15; r.Height = 80; //rectangle1
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 20; r.Y = 140; r.Width = 80; r.Height = 15; //rectangle2
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 100; r.Y = 100; r.Width = 15; r.Height = 55; //rectangle3
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 160; r.Y = 140; r.Width = 80; r.Height = 15; //rectangle4
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 240; r.Y = 95; r.Width = 15; r.Height = 60; //rectangle5
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 160; r.Y = 140; r.Width = 15; r.Height = 80; //rectangle6
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 240; r.Y = 130; r.Width = 80; r.Height = 15; //rectangle7
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 320; r.Y = 100; r.Width = 15; r.Height = 80; //rectangle8
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 270; r.Y = 130; r.Width = 15; r.Height = 100; //rectangle9
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 370; r.Y = 150; r.Width = 15; r.Height = 100; //rectangle10
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 320; r.Y = 250; r.Width = 100; r.Height = 15; //rectangle11
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 20; r.Y = 265; r.Width = 80; r.Height = 15; //rectangle12
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 220; r.Y = 200; r.Width = 15; r.Height = 120; //rectangle13
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 280; r.Y = 310; r.Width = 100; r.Height = 15; //rectangle14
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 280; r.Y = 310; r.Width = 15; r.Height = 80; //rectangle15
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 200; r.Y = 310; r.Width = 80; r.Height = 15; //rectangle16
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 50; r.Y = 320; r.Width = 60; r.Height = 15; //rectangle17
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 110; r.Y = 320; r.Width = 15; r.Height = 80; //rectangle18
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 110; r.Y = 400; r.Width = 90; r.Height = 15; //rectangle18
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 340; r.Y = 380; r.Width = 80; r.Height = 15; //rectangle19
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 230; r.Y = 320; r.Width = 15; r.Height = 100; //rectangle20
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 150; r.Y = 400; r.Width = 15; r.Height = 60; //rectangle21
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 110; r.Y = 350; r.Width = 120; r.Height = 15; //rectangle22
            AddRectangle(r); r = new Rectangle(Color.Red);
            r.X = 20; r.Y = 205; r.Width = 140; r.Height = 15; //rectangle23
            AddRectangle(r); r = new Rectangle(Color.Black);
        
        }
        public void Draw (Graphics g)
        {
            foreach(Rectangle r in rectangles)
            {
                r.Draw(g);
            }
        }
        public bool isSquereColliding()
        {
            
            Rectangle squere=new Rectangle(Color.Black);
            foreach(Rectangle r in rectangles)
            {
                if(r.Color==Color.Black)
                {
                     squere = r;
                }
            }
            foreach(Rectangle r in rectangles)
            {
               
                if(r.Color==Color.Red)
                {
                    Point barrier = new Point(r.X, r.Y);
                 
                    if(squere.X+squere.Width>r.X && squere.Y+squere.Height>r.Y && r.X+r.Width>squere.X && r.Y+r.Height>squere.Y)
                    {
                        squere.isSquereColided = true;
                    }
                    if(squere.isSquereColided)
                    {
                        return true;
                       
                    }
                }
            }
            return false;
        }
    }
}
