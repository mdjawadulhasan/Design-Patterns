// The strategy interface declares operations common to all
// supported versions of some algorithm. The context uses this
// interface to call the algorithm defined by the concrete
// strategies.
interface IStrategy
{
    int Execute(int a, int b);
}

// Concrete strategies implement the algorithm while following
// the base strategy interface. The interface makes them
// interchangeable in the context.
class ConcreteStrategyAdd : IStrategy
{
    public int Execute(int a, int b)
    {
        return a + b;
    }
}

class ConcreteStrategySubtract : IStrategy
{
    public int Execute(int a, int b)
    {
        return a - b;
    }
}

class ConcreteStrategyMultiply : IStrategy
{
    public int Execute(int a, int b)
    {
        return a * b;
    }
}

// The context defines the interface of interest to clients.
class Context
{
    // The context maintains a reference to one of the strategy
    // objects. The context doesn't know the concrete class of a
    // strategy. It should work with all strategies via the
    // strategy interface.
    private IStrategy strategy;

    // Usually the context accepts a strategy through the
    // constructor, and also provides a setter so that the
    // strategy can be switched at runtime.
    public void SetStrategy(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    // The context delegates some work to the strategy object
    // instead of implementing multiple versions of the
    // algorithm on its own.
    public int ExecuteStrategy(int a, int b)
    {
        return strategy.Execute(a, b);
    }
}

// The client code picks a concrete strategy and passes it to
// the context. The client should be aware of the differences
//// between strategies in order to make the right choice.
//class ExampleApplication
//{
//    public void Main()
//    {
//        // Create context object.
//        Context context = new Context();

//        // Read first number.
//        Console.WriteLine("Enter the first number:");
//        int firstNumber = int.Parse(Console.ReadLine());

//        // Read last number.
//        Console.WriteLine("Enter the second number:");
//        int secondNumber = int.Parse(Console.ReadLine());

//        // Read the desired action from user input.
//        Console.WriteLine("Choose an action (addition, subtraction, multiplication):");
//        string action = Console.ReadLine();

//        if (action == "addition")
//        {
//            context.SetStrategy(new ConcreteStrategyAdd());
//        }
//        else if (action == "subtraction")
//        {
//            context.SetStrategy(new ConcreteStrategySubtract());
//        }
//        else if (action == "multiplication")
//        {
//            context.SetStrategy(new ConcreteStrategyMultiply());
//        }
//        else
//        {
//            Console.WriteLine("Invalid action.");
//            return;
//        }

//        int result = context.ExecuteStrategy(firstNumber, secondNumber);

//        Console.WriteLine($"Result: {result}");
//    }
//}
