using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace M5_L53_Abstract_LA1_Manage_Shapes
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    public abstract class Shape
    {
        public Point Centre { get; set; } = new Point(); // has an object Ppoint as a property

        public Shape(double x, double y)
        {
            //To Do
            Centre.X = x;
            Centre.Y = y;

        }

        public void Move(double dx, double dy)
        {
            //ToDo
            Centre.X += dx;
            Centre.Y += dy;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public bool IsSmallerThan(Shape other)
        {
            //ToDo
            if (this.GetArea() < other.GetArea()) return true;
            else return false;
        }

    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double x, double y, double width, double height):base (x,y) // "base(x,y)  "call the Shape constructor of parent class Shape to pass center point
        {
            //ToDo
            Centre.X = x;
            Centre.Y = y;
            Width = width;
            Height = height;

        }

        public override double GetArea()
        {
            //ToDo
            return  Width * Height;
        }

        public override double GetPerimeter()
        {
            //ToDo
            return 2* (Width + Height);
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double x, double y, double radius) : base(x, y)// "base(x,y)  "call the Shape constructor of parent class Shape to pass center point
        {
            //ToDo
            Centre.X = x;
            Centre.Y = y;
            Radius = radius;
        }

        public override double GetArea()
        {
            //ToDo
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            //ToDo
            return 2 * Math.PI * Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int shapeCount = Int32.Parse(Console.ReadLine());
            var shapes = new Shape[shapeCount];
            for (int i = 0; i < shapeCount; ++i)
            {
                var cmd = Console.ReadLine().Split();
                if (cmd[0] == "rectangle")
                {
                    double x = double.Parse(cmd[1]);
                    double y = double.Parse(cmd[2]);
                    double width = double.Parse(cmd[3]);
                    double height = double.Parse(cmd[4]);
                    shapes[i] = new Rectangle(x, y, width, height);
                }
                else if (cmd[0] == "circle")
                {
                    double x = double.Parse(cmd[1]);
                    double y = double.Parse(cmd[2]);
                    double radius = double.Parse(cmd[3]);
                    shapes[i] = new Circle(x, y, radius);
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "exit")
            {
                var cmd = input.Split();
                if (cmd[0] == "move")
                {
                    int index = int.Parse(cmd[1]);
                    double dx = double.Parse(cmd[2]);
                    double dy = double.Parse(cmd[3]);
                    shapes[index].Move(dx, dy);
                }
                else if (cmd[0] == "centre")
                {
                    int index = int.Parse(cmd[1]);
                    Console.WriteLine(shapes[index].Centre.X + ", " + shapes[index].Centre.Y);
                }
                else if (cmd[0] == "area")
                {
                    int index = int.Parse(cmd[1]);
                    Console.WriteLine(shapes[index].GetArea());
                }
                else if (cmd[0] == "perimeter")
                {
                    int index = int.Parse(cmd[1]);
                    Console.WriteLine(shapes[index].GetPerimeter());
                }
                else if (cmd[0] == "issmaller")
                {
                    int index1 = int.Parse(cmd[1]);
                    int index2 = int.Parse(cmd[2]);
                    Console.WriteLine(shapes[index1].IsSmallerThan(shapes[index2]));
                }
            }
        }
    }
}
