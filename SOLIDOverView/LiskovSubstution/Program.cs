// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 * bir base class ile (ondan türeyen) bir derived class tam anlamıyla birbirlerinin yerine kullanılabilir olmalıdır.
 * Aksi taktirde miras olmamalıdır
 * 
 * Derived sınıfın davranışları, base sınıfı değiştiremez!
 */
var rectangle = Create(10,3);


Console.WriteLine(rectangle.Area());

static IShape Create(int width,int height=1)
{
    //....
    if (height == 1)
    {
        var square = new Square();
        square.Width = width;
        return square;
    }
    else
    {
        var rectangle = new Rectangle();
        rectangle.Width = width;
        rectangle.Height = height;
        return rectangle;
    }

}

public interface IShape
{
    int Area();
}
public class Rectangle : IShape
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public Rectangle()
    {
    }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int Area()
    {
        return Width * Height;
    }
}

public class Square : IShape
{
    public int Width { get; set; }
    public int Area()
    {
        return Width * Width;

    }
}
