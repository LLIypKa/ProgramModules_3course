namespace factoryMethod_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string string1;
                string string2;

                string1 = Console.ReadLine();
                string2 = Console.ReadLine();

                ConcreteCreator1 concreteCreator1 = new ConcreteCreator1();
                ConcreteCreator1 concreteCreator2 = new ConcreteCreator2();

                Console.WriteLine(concreteCreator1.AnOperation(string1));
                Console.WriteLine(concreteCreator1.AnOperation(string2));
                Console.WriteLine(concreteCreator2.AnOperation(string1));
                Console.WriteLine(concreteCreator2.AnOperation(string2));
            
        }
    }
}