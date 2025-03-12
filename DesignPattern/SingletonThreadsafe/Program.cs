using System;

namespace SingletonThreadsafe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Invoke two methods in parallel to test thread-safe Singleton
            Parallel.Invoke(InstanceOneCalling, InstanceTwoCalling);
            Console.ReadLine();
        }


        private static void InstanceOneCalling()
        {
            ThreadsafeSingleton instance1 = ThreadsafeSingleton.ThreadsafeInstance;
            instance1.PrintMessage($"Hello from instance1; number of instance: {ThreadsafeSingleton.counter}");
        }


        private static void InstanceTwoCalling()
        {
            ThreadsafeSingleton instance2 = ThreadsafeSingleton.ThreadsafeInstance;
            instance2.PrintMessage($"Hello from instance2; number of instance: {ThreadsafeSingleton.counter}");
        }
    }
}

