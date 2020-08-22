using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vector2D
{
    public float X { get; set; }
    public float Y { get; set; }
    public Vector2D()
    {
        this.X = 0;
        this.Y = 0;
    }
    public Vector2D(float X, float Y)
    {
        this.X = X;
        this.Y = Y;
    }

    public static Vector2D Zero()
    {
        return new Vector2D(0, 0);
    }
    public static Vector2D One()
    {
        return new Vector2D(1, 1);
    }
    public static Vector2D Two()
    {
        return new Vector2D(2, 2);
    }

    public static Vector2D Add(Vector2D a, Vector2D b)
    {
        return new Vector2D(a.X + b.X, a.Y + a.Y);
    }
    public static Vector2D Subtract(Vector2D a, Vector2D b)
    {
        return new Vector2D(a.X - b.X, a.Y - a.Y);
    }
    public static Vector2D Multiply(Vector2D a, Vector2D b)
    {
        return new Vector2D(a.X * b.X, a.Y * a.Y);
    }
    public static Vector2D Devide(Vector2D a, Vector2D b)
    {
        return new Vector2D(a.X / b.X, a.Y / a.Y);
    }
}
