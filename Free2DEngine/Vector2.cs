using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vector2
{
    public float X { get; set; }
    public float Y { get; set; }
    public Vector2()
    {
        this.X = 0;
        this.Y = 0;
    }
    public Vector2(float X, float Y)
    {
        this.X = X;
        this.Y = Y;
    }

    public static Vector2 Zero()
    {
        return new Vector2(0, 0);
    }
    public static Vector2 One()
    {
        return new Vector2(1, 1);
    }
    public static Vector2 Two()
    {
        return new Vector2(2, 2);
    }

    public static Vector2 Add(Vector2 a, Vector2 b)
    {
        return new Vector2(a.X + b.X, a.Y + a.Y);
    }
    public static Vector2 Subtract(Vector2 a, Vector2 b)
    {
        return new Vector2(a.X - b.X, a.Y - a.Y);
    }
    public static Vector2 Multiply(Vector2 a, Vector2 b)
    {
        return new Vector2(a.X * b.X, a.Y * a.Y);
    }
    public static Vector2 Devide(Vector2 a, Vector2 b)
    {
        return new Vector2(a.X / b.X, a.Y / a.Y);
    }
}
