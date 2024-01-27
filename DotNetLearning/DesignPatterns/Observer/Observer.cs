// Subject interface
public interface IWeatherStation
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}

// Observer interface
public interface IObserver
{
    void Update(int temperature, int humidity, int pressure);
}


public class WeatherStation : IWeatherStation
{
    private List<IObserver> observers = new List<IObserver>();
    private int temperature;
    private int humidity;
    private int pressure;

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature, humidity, pressure);
        }
    }

    // Simulate weather changes and notify observers
    public void SetWeather(int temperature, int humidity, int pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        NotifyObservers();
    }
}

// Concrete Observer
public class DisplayDevice : IObserver
{
    private string name;

    public DisplayDevice(string name)
    {
        this.name = name;
    }

    public void Update(int temperature, int humidity, int pressure)
    {
        Console.WriteLine($"{name} Display: Temperature {temperature}°C, Humidity {humidity}%, Pressure {pressure}hPa");
    }
}

//class Program
//{
//    static void Main()
//    {
//        Create a weather station
//        WeatherStation weatherStation = new WeatherStation();

//        Create display devices(observers)
//        IObserver displayDevice1 = new DisplayDevice("Display 1");
//        IObserver displayDevice2 = new DisplayDevice("Display 2");

//        Add display devices as observers to the weather station
//        weatherStation.AddObserver(displayDevice1);
//        weatherStation.AddObserver(displayDevice2);

//        Simulate weather changes
//        weatherStation.SetWeather(25, 60, 1010);

//        Remove one display device
//        weatherStation.RemoveObserver(displayDevice1);

//        Simulate weather changes again
//        weatherStation.SetWeather(28, 65, 1005);
//    }
//}
