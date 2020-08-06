using System;

/// <summary>
/// Represents a shape class
/// </summary>
class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Description of Rectangle class
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Gets and sets width.
    /// </summary>
    public int Width
    {
        get { return width; }
        set {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }

    /// <summary>
    /// Gets and sets height.
    /// </summary>
    /// <value></value>    
    public int Height
    {
        get { return height; }
        set {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }

    /// <summary>
    /// Returns the area of the rectangle.
    /// </summary>
    /// <returns></returns>
    public new int Area()
    {
        return (height * width);
    }

    /// <summary>
    /// Overrides the output for ToString().
    /// </summary>
    public override string ToString()
    {
        return "[Rectangle] " + width + " / " + height;
    }
}

/// <summary>
/// Description for square class
/// </summary>
class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Gets and sets size, height, width
    /// </summary>
    public int Size
    {
        get { return size; }
        set {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            size = value;
            this.Height = value;
            this.Width = value;
        }
    }

    /// <summary>
    /// Overrides the output for ToString().
    /// </summary>
    public override string ToString()
    {
        return "[Square]" + size + " / " + size;
    }
}