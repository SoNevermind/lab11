using System;

namespace lab11
{
    class Program
    {
        abstract class Point
        {
            private int x = 0;
            private int y = 0;
            private int red = 0;
            private int blue = 0;
            private int green = 0;

            private int X
            {
                get
                {
                    return x;
                }

                set
                {
                    if(value > 0)
                    {
                        this.x = value;
                    }
                }
            }

            private int Y
            {
                get
                {
                    return y;
                }

                set
                {
                    if(value > 0)
                    {
                        this.y = value;
                    }
                }
            }

            private int Red
            {
                get
                {
                    return red;
                }

                set
                {
                    if(value > 0)
                    {
                        this.red = value;
                    }
                }
            }

            private int Blue
            {
                get
                {
                    return blue;
                }

                set
                {
                    if(value > 0)
                    {
                        this.blue = value;
                    }
                }
            }

            private int Green
            {
                get
                {
                    return green;
                }

                set
                {
                    if(value > 0)
                    {
                        this.green = value;
                    }
                }
            }

            public Point() { }

            public Point(int X, int Y, int Red, int Blue, int Green)
            {
                this.X = X;
                this.Y = Y;
                this.Red = Red;
                this.Blue = Blue;
                this.Green = Green;
            }

            public void colorEquals(int red, int blue, int green)
            {
                if((this.red < 0 || this.red > 255) || (this.blue < 0 || this.blue > 255) || (this.green < 0 || this.green > 255))
                {
                    Console.WriteLine("For colors you must enter numbers in range from 0 to 255");
                    return;
                }
            }

            public override bool Equals(object obj)
            {
                if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                {
                    return false;
                }
                else
                {
                    Point p = (Point)obj;
                    return (X == p.X) && (Y == p.Y);
                }
            }

            public override int GetHashCode()
            {
                return (X << 2) ^ Y;
            }

            public override string ToString()
            {
                return String.Format("Point(" + X + ", " + Y + "), Color(" + Red + ", " + Blue + ", " + Green + ")");
            }
        }

        class ColorPoint : Point
        {
            public ColorPoint() { }

            public ColorPoint(int x, int y, int red, int blue, int green) : base(x, y, red, blue, green) { }
        }

        static void Main(string[] args)
        {
            int x, y, red, blue, green;

            Console.Write("Enter x coordinates: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y coordinates: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter coordinates of red color: ");
            red = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter coordinates of blue color: ");
            blue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter coordinates of green color: ");
            green = Convert.ToInt32(Console.ReadLine());

            Point point = new ColorPoint(x, y, red, blue, green);

            Console.WriteLine(point.ToString());

            Console.ReadLine();
        }
    }
}
