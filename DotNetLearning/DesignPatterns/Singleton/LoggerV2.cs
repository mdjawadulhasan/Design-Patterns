using DotNetLearning.DesignPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearning.DesignPatterns.Singleton
{
    public class LoggerV2
    {
        private static LoggerV2 _instance;

        // Lock object for thread safety
        private static readonly object _lock = new object();

        // Private constructor to prevent instantiation from outside the class
        private LoggerV2()
        {
            // Initialization logic here
        }

        // Public method to get the single instance of the class
        public static LoggerV2 Instance
        {
            get
            {
                // Double-check locking for thread safety
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            Thread.Sleep(10);
                            _instance = new LoggerV2();
                        }
                    }
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
//        Console.WriteLine("Logger V2 Program");
//        LoggerV2 logger1 = null;
//        LoggerV2 logger2 = null;

//        // Create multiple threads that access the Logger.Instance property concurrently
//        Thread thread1 = new Thread(() =>
//        {
//            logger1 = LoggerV2.Instance;
//            logger1.Log("Thread 1 log entry.");
//        });

//        Thread thread2 = new Thread(() =>
//        {
//            logger2 = LoggerV2.Instance;
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
