using System;

namespace SingletonThreadsafe
{
    public sealed class ThreadsafeSingleton
    {
        // Private static field to hold the single instance of the class
        private static ThreadsafeSingleton instance = null;
        // Object used for locking to ensure thread safety
        private static readonly object padlock = new object();
        public static int counter = 0;

        // Private constructor to prevent instantiation from outside the class
        private ThreadsafeSingleton()
        {
            Console.WriteLine($"Instance created: {++counter}");
        }

        // Public static property to provide global access to the single instance
        public static ThreadsafeSingleton ThreadsafeInstance
        {
            /*
             * Not thread safe
             * 
             * get
             * {
             *     if (instance == null)
             *         instance = new ThreadsafeSingleton();
             *     return instance;
             * }
             */

            // Double check locking to ensure thread safety
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                            instance = new ThreadsafeSingleton();
                    }
                }
                return instance;
            }
        }

        // Public method to print a message
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}