public interface IVehicle
{
    void Drive();
}

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a car");
    }
}

public class Bike : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a Suzuki");
    }
}


public interface IVehicleFactory
{
    IVehicle CreateVehicle();
}


public class CarFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new Car();
    }
}

public class BikeFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new Bike();
    }
}


//class Program
//{
//    static void Main()
//    {
//        IVehicleFactory carFactory = new CarFactory();
//        IVehicle car = carFactory.CreateVehicle();
//        car.Drive();


//        IVehicleFactory bikeFactory = new BikeFactory();
//        IVehicle bike = bikeFactory.CreateVehicle();
//        bike.Drive();
//    }
//}
