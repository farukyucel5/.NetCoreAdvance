namespace BaseClassConstructor
{
    internal class MainClass
    {

        static void Main(string[] args)
        {
            ChildClass childClass = new("Product A");
            childClass.Add();

        }
    }
    internal class BaseClass
    {
        private readonly string _entity;

        public BaseClass(string entity)
        {

            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine($"{_entity} message");
        }


    }

    internal class ChildClass : BaseClass
    {
        public ChildClass(string entity) : base(entity)
        {

        }

        public void Add()
        {

            Console.WriteLine("Added");
            Message();
        }
   
    }


}