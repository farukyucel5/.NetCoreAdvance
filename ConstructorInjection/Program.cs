namespace ConstructorInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager employeeManager = new(new SmsLogger());
            employeeManager.Add();
            Console.ReadLine();

        }
    }

    class EmployeeManager
    {
        private readonly ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;     
        }

        public void Add()
        {
            _logger.Log();
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