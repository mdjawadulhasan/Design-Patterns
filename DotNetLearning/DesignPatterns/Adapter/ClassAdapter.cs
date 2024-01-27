// Target interface that the client expects
interface ITarget
{
    void Request();
}

//Adaptee (existing class) with a different interface
class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Adaptee's specific request");
    }
}

// Adapter class that adapts Adaptee to ITarget
class ClassAdapter : Adaptee, ITarget
{
    public void Request()
    {
        // Call the existing method from Adaptee
        // It allows the Adaptee's SpecificRequest method to be used as if it were the Request method from the ITarget interface
        SpecificRequest();
    }
}

// Client code that expects an ITarget interface
//class Client
//{
//    public void MakeRequest(ITarget target)
//    {
//        target.Request();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Client interacts with the Adapter through the ITarget interface
//        ITarget adapter = new ClassAdapter();
//        Client client = new Client();
//        client.MakeRequest(adapter);
//    }
//}
