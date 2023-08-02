namespace RecapDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new();
            customerManager.Logger=new FileLogger();
            customerManager.Add();
            Console.ReadLine();

        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }

        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added");
        }
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Sms!");
        }
    }

    interface ILogger
    {
        void Log();
    }

}