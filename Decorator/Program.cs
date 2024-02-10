using System.ComponentModel;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char C;
            int N;
            string operatorString;
            List<Component> components = new List<Component>();

            C = Convert.ToChar(Console.ReadLine());
            N = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            { 
                operatorString = Console.ReadLine();

                string[] operators = operatorString.Split(' ');
                components.Add(new ConcreteComponent(operators[0]));
                try
                {
                    foreach (char ch in operators[1])
                    {
                        if (ch == 'A') components.Add(new ConcreteDecoratorA(components[components.Count() - 1], C));
                        if (ch == 'B') components.Add(new ConcreteDecoratorB(components[components.Count() - 2]));
                    }
                }
                catch { continue; }
            }

            for (int i = 0; i <= components.Count() - 1; i++)
            {
                Console.WriteLine(components[i].Operation());
            }
        }
    }
}