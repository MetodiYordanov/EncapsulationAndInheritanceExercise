using System;
using System.Text;

namespace BoxData;

public class Box
{
    private double length;
    private double width;
    private double height;

    private const double MIN_DATA_VALUE = 0;

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double Length 
    { 
        get
        {
            return this.length;
        }
        private set
        { 
            if (value <= MIN_DATA_VALUE)
            {
                throw new ArgumentException($"{this.Length} cannot be zero or negative.");
            }
            this.length = value; 
        }
    }

    public double Width
    {
        get
        {
            return this.width;
        }
        private set
        {
            if (value <= MIN_DATA_VALUE)
            {
                throw new ArgumentException($"{this.Width} cannot be zero or negative.");
            }
            this.width = value;
        }
    }

    public double Height
    {
        get
        {
            return this.height;
        }
        private set
        {
            if (value <= MIN_DATA_VALUE)
            {
                throw new ArgumentException($"{this.Height} cannot be zero or negative.");
            }
            this.height = value;
        }
    }

    public double SurfaceArea()
    {
        double result = 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        return result;
    }

    public double Volume()
    {
        double rsult = this.Length * this.Width * this.Height;
        return rsult;
    }

    public override string ToString()
    {
        return $"Surface Area - {this.SurfaceArea():F2}{Environment.NewLine}Volume - {this.Volume():F2}";
    }
}
