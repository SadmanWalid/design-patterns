
namespace DesignPatterns.SingletonLazyLoading
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
        SingletonLazyLoading instance1 = SingletonLazyLoading.Instance;
        Console.WriteLine($"Hello from instance1; number of instance: {SingletonLazyLoading.instanceCount}");
    }

    private static void InstanceTwoCalling()
    {
        SingletonLazyLoading instance2 = SingletonLazyLoading.Instance;
        Console.WriteLine($"Hello from instance2; number of instance: {SingletonLazyLoading.instanceCount}");
    }
    

  }
}