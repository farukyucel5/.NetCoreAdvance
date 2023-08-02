namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Faruk", "Furkan", "Merve", "Hasan", "Harun" };
            //try
            //{
            //    Find(list, "Fırat");
            //}
            //catch (RecordNotFoundException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            //try
            //{
            //    Find(list, "Fırat");
            //}
            //catch (Exception exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            HandleException(() => Find(list,"Fırat"));//exception delegation
        }

        private static void HandleException(Action value)
        {
            try
            {
                value.Invoke();
            }catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        static void Find(List<string> list,string item)
        {

            if (!list.Contains(item))
            {
                throw new RecordNotFoundException("record not found in the collection");
            }
            else
            {
                Console.WriteLine($"{item} found!");
            }

           
        }
    }
}