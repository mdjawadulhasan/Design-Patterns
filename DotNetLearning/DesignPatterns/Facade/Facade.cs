// Subsystem A
public class SubsystemA
{
    public void OperationA()
    {
        Console.WriteLine("SubsystemA: OperationA");
    }
}

// Subsystem B
public class SubsystemB
{
    public void OperationB()
    {
        Console.WriteLine("SubsystemB: OperationB");
    }
}

// Subsystem C
public class SubsystemC
{
    public void OperationC()
    {
        Console.WriteLine("SubsystemC: OperationC");
    }
}

// Facade
public class Facade
{
    private SubsystemA subsystemA;
    private SubsystemB subsystemB;
    private SubsystemC subsystemC;

    public Facade()
    {
        this.subsystemA = new SubsystemA();
        this.subsystemB = new SubsystemB();
        this.subsystemC = new SubsystemC();
    }

    // Facade methods that simplify the interactions with the subsystems
    public void Operation1()
    {
        Console.WriteLine("Facade: Operation1");
        subsystemA.OperationA();
        subsystemB.OperationB();
    }

    public void Operation2()
    {
        Console.WriteLine("Facade: Operation2");
        subsystemB.OperationB();
        subsystemC.OperationC();
    }
}

//class Program
//{
//    static void Main()
//    {
//        // Using the Facade to simplify interactions with the subsystems
//        Facade facade = new Facade();

//        Console.WriteLine("Client uses the Facade to perform operations:");
//        facade.Operation1();
//        facade.Operation2();
//    }
//}
