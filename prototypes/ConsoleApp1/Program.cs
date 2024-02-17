namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            string S;
            List<int> ints;
            Client client1;
            Client client2;

            S = Console.ReadLine();
            N = Int32.Parse(Console.ReadLine());
            ints = new List<int>(N);
            client1 = new Client(new ConcretePrototype1(S, 0));
            client2 = new Client(new ConcretePrototype2(S, 0));
            for (int i = 0; i < N; i++)
                ints.Add(Int32.Parse(Console.ReadLine()));
            foreach(int id in ints)
            {
                client1.Operation(id);
                client2.Operation(id);
            }

            Console.WriteLine(client1._prot.GetInfo());
            Console.WriteLine(client1.GetObjects());
            Console.WriteLine(client2.GetObjects());
        }
    }
}