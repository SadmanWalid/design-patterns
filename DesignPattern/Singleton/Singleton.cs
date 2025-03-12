namespace Singleton
{
    // The sealed keyword prevents other classes from inheriting from this class,
    // ensuring that the Singleton pattern is not violated.
    public sealed class Singleton
    {

        public static int instanceCount = 0;

        // Private static field to hold the single instance of the class
        private static Singleton instance = null;

        // Private constructor to prevent instantiation from outside the class
        private Singleton()
        {
            instanceCount++;
            Console.WriteLine($"Instances created: {instanceCount}");
        }

        // Public static property to provide global access to the single instance
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
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