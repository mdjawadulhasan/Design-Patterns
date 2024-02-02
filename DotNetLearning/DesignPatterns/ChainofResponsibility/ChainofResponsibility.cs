// Handler interface
public interface IHandler
{
    IHandler SetNextHandler(IHandler handler);
    void HandleRequest(Request request);
}

// Concrete Handler 1
public class ConcreteHandler1 : IHandler
{
    private IHandler nextHandler;

    public IHandler SetNextHandler(IHandler handler)
    {
        nextHandler = handler;
        return handler;
    }

    public void HandleRequest(Request request)
    {
        if (request.Level <= 10)
        {
            Console.WriteLine($"ConcreteHandler1 handling request with level {request.Level}");
        }
        else if (nextHandler != null)
        {
            Console.WriteLine($"ConcreteHandler1 passing request with level {request.Level} to the next handler");
            nextHandler.HandleRequest(request);
        }
        else
        {
            Console.WriteLine($"ConcreteHandler1 cannot handle request with level {request.Level}");
        }
    }
}

// Concrete Handler 2
public class ConcreteHandler2 : IHandler
{
    private IHandler nextHandler;

    public IHandler SetNextHandler(IHandler handler)
    {
        nextHandler = handler;
        return handler;
    }

    public void HandleRequest(Request request)
    {
        if (request.Level > 10 && request.Level <= 20)
        {
            Console.WriteLine($"ConcreteHandler2 handling request with level {request.Level}");
        }
        else if (nextHandler != null)
        {
            Console.WriteLine($"ConcreteHandler2 passing request with level {request.Level} to the next handler");
            nextHandler.HandleRequest(request);
        }
        else
        {
            Console.WriteLine($"ConcreteHandler2 cannot handle request with level {request.Level}");
        }
    }
}

// Request class
public class Request
{
    public int Level { get; }

    public Request(int level)
    {
        Level = level;
    }
}

//class Program
//{
//    static void Main()
//    {
//        // Create handlers
//        IHandler handler1 = new ConcreteHandler1();
//        IHandler handler2 = new ConcreteHandler2();

//        // Set up the chain of responsibility
//        handler1.SetNextHandler(handler2);

//        // Create requests
//        Request request1 = new Request(5);
//        Request request2 = new Request(15);
//        Request request3 = new Request(25);

//        // Process requests
//        handler1.HandleRequest(request1);
//        Console.WriteLine();

//        handler1.HandleRequest(request2);
//        Console.WriteLine();

//        handler1.HandleRequest(request3);
//    }
//}
