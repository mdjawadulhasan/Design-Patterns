using DotNetLearning.DesignPatterns.Singleton;

namespace DotNetLearning.DesignPatterns.Singleton
{
    public class Logger
    {
        // Private static instance variable to hold the single instance
        private static Logger _instance;

        // Private constructor to prevent instantiation from outside the class
        private Logger()
        {
            // Initialization logic here
        }

        // Public method to get the single instance of the class
        public static Logger Instance
        {
            get
            {
                // Double-check locking for thread safety
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }

        // Other logging methods can be added here
        public void Log(string message)
        {
            Console.WriteLine($"Logging: {message}");
        }
    }
}





//class Program
//{
//    static async Task Main()
//    {
//        Console.WriteLine("Logger V1 Program");
//        // Get the single instance of Logger
//        Logger logger = Logger.Instance;

//        // Use the logger to log messages
//        logger.Log("Application started.");

//        // Another part of the application can also use the same logger instance
//        Logger anotherLogger = Logger.Instance;
//        anotherLogger.Log("Another log entry.");


//        // Both logger and anotherLogger point to the same instance

//        Console.WriteLine($"Reference of logger: {logger.GetHashCode()}");
//        Console.WriteLine($"Reference of anotherLogger: {anotherLogger.GetHashCode()}");
//        Console.WriteLine($"Are both loggers the same instance? {ReferenceEquals(logger, anotherLogger)}");

//    }
//}
