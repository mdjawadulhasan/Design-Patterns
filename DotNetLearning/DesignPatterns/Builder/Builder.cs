// Product class represents the complex object to be built
class Product
{
    public string Part1 { get; set; }
    public string Part2 { get; set; }

    public void Display()
    {
        Console.WriteLine($"Part 1: {Part1}");
        Console.WriteLine($"Part 2: {Part2}");
    }
}

// Builder interface defines the steps to build the product
interface IBuilder
{
    void BuildPart1();
    void BuildPart2();
    Product GetResult();
}

// ConcreteBuilder class implements the Builder interface and builds the product
class ConcreteBuilder : IBuilder
{
    private Product product;
    public ConcreteBuilder()
    {
        product = new Product();
    }

    public void BuildPart1()
    {
        product.Part1 = "Part 1 built";
    }

    public void BuildPart2()
    {
        product.Part2 = "Part 2 built";
    }

    public Product GetResult()
    {
        return product;
    }
}

// Director class orchestrates the construction using the builder
class Director
{
    public void Construct(IBuilder builder)
    {
        builder.BuildPart1();
        builder.BuildPart2();
    }
}

// Client code
//class Program
//{
//    static void Main()
//    {
//        // Create a director
//        Director director = new Director();

//        // Create a concrete builder
//        IBuilder builder = new ConcreteBuilder();

//        // Construct the product using the builder
//        director.Construct(builder);

//        // Get the final product
//        Product product = builder.GetResult();

//        // Display the product
//        product.Display();

//    }
//}
