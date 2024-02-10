namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            string leters;
            List<Component> components;
            List<int> parentIndex;

            N = Convert.ToInt32(Console.ReadLine());
            leters = Console.ReadLine();
            components = new List<Component>();
            parentIndex = new List<int>();
            for (int i = 0; i < N; i++)
            {
                if (Char.IsUpper(leters[i]))
                    components.Add(new Composite1(leters[i]));
                else components.Add(new Leaf(leters[i]));

            }
            for (int i = 0; i < N; i++)
            {
                parentIndex.Add(Int32.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < N; i++)
            {
                int index = parentIndex[i];
                if (index < 0) continue;

                components[index].AddComponent(components[i]);
            }

            foreach (Component component in components)
            {
                Console.WriteLine(component.Operation());
            }
        }
    }
}