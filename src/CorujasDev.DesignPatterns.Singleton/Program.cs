// See https://aka.ms/new-console-template for more information
using CorujasDev.DesignPatterns.Singleton;

Console.WriteLine("Implementation Singleton");

var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if(instance1 == instance2 && instance2 == Logger.Instance)
{
    Console.WriteLine("Instances are the same");
}

instance1.Log($"Message from {instance1}");
instance2.Log($"Message from {instance2}");
Logger.Instance.Log($"Message from {Logger.Instance}");

Console.ReadLine();