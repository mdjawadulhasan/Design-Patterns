interface IRect
{
    void AboutRectangle();
    double CalculateAreaOfRectangle();

}


interface ITriangle
{
    void AboutTriangle();
    double CalculateAreaOfTriangle();
}


public class Rect : IRect
{
    public double Length;
    public double Width;
    public Rect(double l, double w)
    {
        this.Length = l;
        this.Width = w;
    }
    public double CalculateAreaOfRectangle()
    {
        return Length * Width;
    }
    public void AboutRectangle()
    {
        Console.WriteLine("Actually, I am a Rectangle");
    }
}


public class Triangle : ITriangle
{
    public double BaseLength;//base
    public double Height;//height
    public Triangle(double b, double h)
    {
        this.BaseLength = b;
        this.Height = h;
    }
    public double CalculateAreaOfTriangle()
    {
        return 0.5 * BaseLength * Height;
    }
    public void AboutTriangle()
    {
        Console.WriteLine("Actually, I am a Triangle");
    }
}


public class TriangleAdapter : IRect
{
    Triangle triangle;
    public TriangleAdapter(Triangle t)
    {
        this.triangle = t;
    }

    public void AboutRectangle()
    {
        triangle.AboutTriangle();
    }
    public double CalculateAreaOfRectangle()
    {
        return triangle.CalculateAreaOfTriangle();
    }
}


//class Program
//{
//    static void Main()
//    {

//        IRect rectangle = new Rect(5, 10);
//        ITriangle triangle = new Triangle(4, 8);


//        // Display information about Rectangle
//        rectangle.AboutRectangle();
//        Console.WriteLine($"Area of Rectangle: {rectangle.CalculateAreaOfRectangle()}");

//        // Display information about Triangle
//        triangle.AboutTriangle();
//        Console.WriteLine($"Area of Triangle: {triangle.CalculateAreaOfTriangle()}");

//        Console.WriteLine();

//        // Use the Adapter to make Triangle compatible with IRect interface
//        var triangle2 = new Triangle(10, 5);
//        IRect triangleAdapter = new TriangleAdapter(triangle2);

//        // Display information about Triangle using the IRect interface
//        triangleAdapter.AboutRectangle();
//        Console.WriteLine($"Area of Triangle (using IRect): {triangleAdapter.CalculateAreaOfRectangle()}");

//        Console.ReadLine();
//    }
//}