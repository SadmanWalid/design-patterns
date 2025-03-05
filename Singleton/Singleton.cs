namespace Singleton
{
    public sealed class Singleton
    {
        public static int instanceCount = 0;
        private static  Singleton instance = null;
        private  Singleton()
        {
            instanceCount++;
            Console.WriteLine($"Instances created: {instanceCount}");
            
        }

        public static Singleton Instance 
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
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