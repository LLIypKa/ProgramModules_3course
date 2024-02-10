using System.ComponentModel;

namespace Composite1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            string leters;
            List<Device> components;
            List<int> parentIndex;

            N = Convert.ToInt32(Console.ReadLine());
            components = new List<Device>();
            parentIndex = new List<int>();
            for (int i = 0; i < N; i++)
            {
                leters = Console.ReadLine();
                string[] x = leters.Split(' ');
                if (Char.IsUpper(x[0][0]))
                    components.Add(new CompoundDevice(x[0], Int32.Parse(x[1])));
                else components.Add(new SimpleDevice(x[0], Int32.Parse(x[1])));

            }
            for (int i = 0; i < N; i++)
            {
                parentIndex.Add(Int32.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < N; i++)
            {
                int index = parentIndex[i];
                if (index < 0) continue;

                components[index].Add(components[i]);
            }

            foreach (Device component in components)
            {
                Console.WriteLine($"name: {component.GetName()}, price: {component.GetTotalPrice()}");
            }
        }
    }
}