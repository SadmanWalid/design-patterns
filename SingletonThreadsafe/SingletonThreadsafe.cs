using System;

namespace SingletonThreadsafe
{
    public sealed class ThreadsafeSingleton
    {
        private static ThreadsafeSingleton instance = null;
        private static readonly object padlock = new object();
        public static int counter = 0;

        private ThreadsafeSingleton()
        {
            
           Console.WriteLine($"Instance created: {++counter}");
        }

        public static ThreadsafeSingleton ThreadsafeInstance
        {
            /*
             * not thread safe
             * 
             
                get
                {
                    if (instance == null)
                        instance = new ThreadsafeSingleton();

                    return instance;
                } 
            */

            // Double check locking
            get
            { 
                if( instance == null)
                {
                    lock( padlock )
                    {
                        if( instance == null )
                            instance = new ThreadsafeSingleton();
                    }
                }
                return instance;

            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}