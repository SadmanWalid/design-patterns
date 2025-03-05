
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;
            instance1.PrintMessage("Hello from instance1");
            instance2.PrintMessage("Hello from instance2");
            instance1.PrintMessage($"Number of instance created: {Singleton.instanceCount}");
        }
    }

   

}