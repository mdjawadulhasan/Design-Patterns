using System;
using System.Net.Http;
using Polly;
using Polly.CircuitBreaker;

class Program
{
    static void Main()
    {
        // Simulating an e-commerce website calling a payment processing service
        var ecommerceCircuitBreaker = CreateCircuitBreaker();

        for (int i = 0; i < 10; i++)
        {
            try
            {
                ecommerceCircuitBreaker.Execute(() =>
                {
                    // Simulate making a request to the payment processing service
                    SimulatePaymentProcessingServiceRequest();
                });

                Console.WriteLine("Payment processing successful.");
            }
            catch (BrokenCircuitException)
            {
                Console.WriteLine("Circuit is open. Payment processing service is unavailable.");
            }
        }
    }

    static void SimulatePaymentProcessingServiceRequest()
    {
        // Simulate making a request to the payment processing service
        // For simplicity, we'll randomly throw an exception to simulate a failure
        var random = new Random();
        if (random.Next(10) < 3) // 30% chance of failure
        {
            throw new Exception("Payment processing service failure.");
        }
    }

    static CircuitBreakerPolicy CreateCircuitBreaker()
    {
        // Create a circuit breaker policy with Polly
        var circuitBreaker = Policy
            .Handle<Exception>()
            .CircuitBreaker(3, TimeSpan.FromSeconds(5), OnBreak, OnReset);

        return circuitBreaker;
    }

    static void OnBreak(Exception ex, TimeSpan duration)
    {
        Console.WriteLine($"Circuit is open. {duration.TotalSeconds} seconds remaining.");
    }

    static void OnReset()
    {
        Console.WriteLine("Circuit is reset. Resuming normal operations.");
    }
}
