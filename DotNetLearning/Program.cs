//using System;

//// Base class
//class Shape
//{
//    public virtual void Draw()
//    {
//        Console.WriteLine("Drawing a shape");
//    }
//}

//// Subclass 1
//class Circle : Shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Drawing a circle");
//    }
//}

//// Subclass 2
//class Square : Shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Drawing a square");
//    }
//}

//class Program
//{
//    static void DrawShape(Shape shape)
//    {
//        shape.Draw();
//    }

//    static void Main()
//    {
//        // Using Liskov Substitution Principle
//        Shape shape1 = new Circle();
//        Shape shape2 = new Square();

//        // Both Circle and Square can be used interchangeably with Shape
//        DrawShape(shape1); // Output: Drawing a circle
//        DrawShape(shape2); // Output: Drawing a square

//        Console.ReadLine();
//    }
//}
