namespace DotNetLearning
{
    public class AsyncAwait
    {
        public static async Task RunDemo()
        {
            Console.WriteLine("Start Main");

            Task<string> taskA = DoTaskAAsync();
            Console.WriteLine("Main continues doing other work while waiting for TaskA");

            //Case 1

            //here the execution will stop until the result come from the DoTaskAAsync method
            //Loop will not execute until the result comes from the DoTaskAAsync method

            //string resultA = await taskA;
            //Console.WriteLine($"TaskA result: {resultA}");



            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"Main is doing some other work ({i + 1}/3)");
                await Task.Delay(1000);
            }



            //Case 2

            //If I put that there, the DoTaskAAsync method will be called, and the control will return
            //to the main method. The loop will continue executing, and as soon as the result
            //comes back from the DoTaskAAsync method, that result will get printed.

            string resultA = await taskA;
            Console.WriteLine($"TaskA result: {resultA}");


        }

        private static async Task<string> DoTaskAAsync()
        {
            Console.WriteLine("Start TaskA");
            await Task.Delay(3000);
            Console.WriteLine("TaskA completed");
            return "Result from TaskA";
        }
    }
}


// await AsyncAwait.RunDemo();