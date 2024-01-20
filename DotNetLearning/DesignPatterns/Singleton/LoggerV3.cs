using DotNetLearning.DesignPatterns.Singleton;

namespace DotNetLearning.DesignPatterns.Singleton
{
    public class LoggerV3
    {
        private static LoggerV3 _instance;
        private LoggerV3()
        {
            // Initialization logic here
        }
        public static LoggerV3 Instance
        {
            get
            {
                if (_instance == null)
                {
                    // Simulate a delay to exaggerate the race condition
                    //Added delay increases the window of opportunity for multiple threads to enter the critical section concurrently.
                    Thread.Sleep(10);
                    _instance = new LoggerV3();
                }
                return _instance;
            }
        }

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
//        Console.WriteLine("Logger V3 Program");
//        LoggerV3 logger1 = null;
//        LoggerV3 logger2 = null;

//        // Create multiple threads that access the Logger.Instance property concurrently
//        Thread thread1 = new Thread(() =>
//        {
//            logger1 = LoggerV3.Instance;
//            logger1.Log("Thread 1 log entry.");
//        });

//        Thread thread2 = new Thread(() =>
//        {
//            logger2 = LoggerV3.Instance;
//            logger2.Log("Thread 2 log entry.");
//        });

//        // Start both threads concurrently
//        thread1.Start();
//        thread2.Start();

//        // Wait for both threads to complete
//        thread1.Join();
//        thread2.Join();

//        // Check if the instances are equal
//        bool areInstancesEqual = ReferenceEquals(logger1, logger2);

//        // Output the result
//        Console.WriteLine($"Reference of logger: {logger1.GetHashCode()}");
//        Console.WriteLine($"Reference of anotherLogger: {logger2.GetHashCode()}");
//        Console.WriteLine($"Are both instances of Logger equal? {areInstancesEqual}");
//        Console.ReadLine();

//    }
//}
