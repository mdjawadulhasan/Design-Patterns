interface ICommand
{
    void Execute();
}

// ConcreteCommand classes
class LightOnCommand : ICommand
{
    private Light light;

    public LightOnCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.TurnOn();
    }
}

class LightOffCommand : ICommand
{
    private Light light;

    public LightOffCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.TurnOff();
    }
}

// Receiver classes
class Light
{
    public void TurnOn()
    {
        Console.WriteLine("Light is ON");
    }

    public void TurnOff()
    {
        Console.WriteLine("Light is OFF");
    }
}


// Invoker class
class RemoteControl
{
    private ICommand command;

    public void SetCommand(ICommand command)
    {
        this.command = command;
    }

    public void PressButton()
    {
        command.Execute();
    }
}


//class Program
//{
//    static void Main()
//    {
//        // Creating instances
//        Light livingRoomLight = new Light();

//        // Creating commands
//        ICommand lightOnCommand = new LightOnCommand(livingRoomLight);
//        ICommand lightOffCommand = new LightOffCommand(livingRoomLight);

//        // Setting up invokers with commands
//        RemoteControl remoteControl = new RemoteControl();
//        remoteControl.SetCommand(lightOnCommand);

//        // Invoking the command
//        remoteControl.PressButton();

//        // Changing the command
//        remoteControl.SetCommand(lightOffCommand);
//        remoteControl.PressButton();
//    }
//}
