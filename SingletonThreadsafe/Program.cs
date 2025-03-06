using System;

namespace SingletonThreadsafe
{
    class Program
    {
         static void Main(string[] args)
        {
           
            Parallel.Invoke(InstanceOneCalling, InstanceTwoCalling);
            Console.ReadLine();

            
        }

        private static void  InstanceOneCalling()
        {

            ThreadsafeSingleton instance1 = ThreadsafeSingleton.ThreadsafeInstance;
            instance1.PrintMessage($"Hello from instance1; number of instance:  {ThreadsafeSingleton.counter}");

        }

        private static void InstanceTwoCalling()
        {
            ThreadsafeSingleton instance2 = ThreadsafeSingleton.ThreadsafeInstance;
            instance2.PrintMessage($"Hello from instance2; number of instance:  {ThreadsafeSingleton.counter}");
        }
    }
}   

