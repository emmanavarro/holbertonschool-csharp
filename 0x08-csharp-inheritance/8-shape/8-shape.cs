using System;

/// <summary>Shape class defines methods to work with shapes</summary>
class Shape
{
    /// <summary>Public Area() method that calculates the area of a shape</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>Rectangle class defines properties to work with rectangles</summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>Public property get/set for width</summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }

    /// <summary>Public property get/set for height</summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }

    /// <summary>Public Area() method that overrides the base class implementation of area</summary>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>Public ToString() method that overrides the default output</summary>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}

/// <summary>Square class defines properties to work with squares</summary>
class Square : Rectangle
{
    private int size;

    /// <summary>Public property get/set for size</summary>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
            {
                size = value;
                Height = value;
                Width = value;
            }
        }
    }
}
