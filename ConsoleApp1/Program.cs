namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerfectNumbersUpTo1000();

        }

        private static void PerfectNumbersUpTo1000()
        {
            for (int i = 1; i < 1000; i++)
            {
                if (Mukemmmelsayı(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool Mukemmmelsayı(int num)
        {
            int sum = 0;
            for (int i = 1; i <num; i++)
            {
                
                if(num%i == 0)
                {
                    sum += i;

                }

            }

            if (sum == num)
                return true;
            

            return false;
        }
    }
}