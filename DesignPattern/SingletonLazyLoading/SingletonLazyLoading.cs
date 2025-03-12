namespace DesignPatterns.SingletonLazyLoading
{
    public sealed class SingletonLazyLoading
    {
        public static int instanceCount = 0;

        // Lazy initialization ensures that the instance is created only when it is accessed for the first time. 
        // Lazy<T> is by default thread-safe.
        private static Lazy<SingletonLazyLoading> singletonInstance =
           new Lazy<SingletonLazyLoading>(() => new SingletonLazyLoading());

        private SingletonLazyLoading()
        {
            // Private constructor to prevent instantiation from outside the class
            Console.WriteLine($"Instance created, number of instances: {++instanceCount}");
        }

        public static SingletonLazyLoading Instance
        {
            get
            {
                return singletonInstance.Value;
            }
        }
    }
}
