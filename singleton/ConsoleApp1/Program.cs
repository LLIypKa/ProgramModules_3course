using System.ComponentModel;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;
            const int K = 15;
            string[] commands = new string[N]
            {
                "S", "D1", "D2", "T0", "T1", "T2"
                , "T3", "T4", "T5", "T9"
            };
            BaseClass[] b = new BaseClass[N];
            int[] keys = new int[K];
            int[] values = new int[K];
            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {
                if (commands[i] == "S")
                {
                    b[i] = Singleton.Instance();
                    continue;
                }
                if (commands[i] == "D1")
                {
                    b[i] = Doubleton.Instance1();
                    continue;
                }
                if (commands[i] == "D2")
                {
                    b[i] = Doubleton.Instance2();
                    continue;
                }
                if (commands[i] == "T0")
                {
                    b[i] = Tenton.Instances(0);
                    continue;
                }
                if (commands[i] == "T1")
                {
                    b[i] = Tenton.Instances(1);
                    continue;
                }
                if (commands[i] == "T2")
                {
                    b[i] = Tenton.Instances(2);
                    continue;
                }
                if (commands[i] == "T3")
                {
                    b[i] = Tenton.Instances(3);
                    continue;
                }
                if (commands[i] == "T4")
                {
                    b[i] = Tenton.Instances(4);
                    continue;
                }
                if (commands[i] == "T5")
                {
                    b[i] = Tenton.Instances(5);
                    continue;
                }
                if (commands[i] == "T6")
                {
                    b[i] = Tenton.Instances(6);
                    continue;
                }
                if (commands[i] == "T7")
                {
                    b[i] = Tenton.Instances(7);
                    continue;
                }
                if (commands[i] == "T8")
                {
                    b[i] = Tenton.Instances(8);
                    continue;
                }
                if (commands[i] == "T9")
                {
                    b[i] = Tenton.Instances(9);
                }
            }

            Console.WriteLine(Singleton.InstanceCount());
            Console.WriteLine(Doubleton.InstanceCount());
            Console.WriteLine(Tenton.InstanceCount());

            for (int i = 0; i < K; i++)
            {
                keys[i] = rand.Next(0, N - 1);
                values[i] = rand.Next(0, 100);

                b[keys[i]].IncData(values[i]);
            }

            for(int i = 0; i < N; i++)
            {
                Console.WriteLine(b[i].GetData());
            }
        }
    }
}