using System;

public class ColorRGBA
{
    public float R { get; set; }
    public float G { get; set; }
    public float B { get; set; }
    public float A { get; set; }

    public ColorRGBA()
    {
        R = 1;
        G = 1;
        B = 1;
        A = 1;
    }
    public ColorRGBA(float r,float g, float b, float a)
    {
        R = r;
        G = g;
        B = b;
        A = a;
    }
}
