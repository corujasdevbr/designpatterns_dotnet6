
namespace CorujasDev.DesignPatterns.Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {
        //Validate that the class in your building will only be instanced once
        private static readonly Lazy<Logger> _lazyLogger
            = new Lazy<Logger>(() => new Logger());

        public static Logger Instance => _lazyLogger.Value;

        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}
