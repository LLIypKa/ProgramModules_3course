namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Nf, Na, Nb;
            string S;

            AbstractFactory f;
            AbstractProductA pa;
            AbstractProductB pb;

            Nf = Int32.Parse(Console.ReadLine());
            Na = Int32.Parse(Console.ReadLine());
            Nb = Int32.Parse(Console.ReadLine());
            S = Console.ReadLine();

            if (Nf == 1)
            {
                f = new Factory1(Na, Nb);
            }
            else
            {
                f = new Factory2(Na, Nb);
            }

            pa = f.CreateProductA();
            pb = f.CreateProductB();

            foreach (char c in S)
            {
                if (c == 'A')
                {
                    pa.A();
                }
                else
                {
                    pb.B(pa);
                }
            }

            Console.WriteLine(pa.GetInfo());
            Console.WriteLine(pb.GetInfo());
        }
    }
}