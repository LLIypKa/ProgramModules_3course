using Adapter;
using System.Collections.Generic;

int Main()
{
    int N, A, B;
    char C;
    string command;
    List<Target> targets;

    N = Int32.Parse(Console.ReadLine());
    targets = new List<Target>();
    for(int i = 0; i < N;i++)
    {
        command = Console.ReadLine();
        C = Convert.ToChar(command.Split(" ")[0]);
        A = Convert.ToInt32(command.Split(" ")[1]);
        B = Convert.ToInt32(command.Split(" ")[2]);
        switch (C)
        {
            case '+':
                targets.Add(new ConcreteTarget(A, B));
                break;
            case '*':
                targets.Add(new Adapters(A, B));
                break;
        }
    }    

    for(int i = 0; i < N; i++)
    {
        Console.WriteLine($"target{i + 1}");
        Console.WriteLine(targets[i].GetA());
        Console.WriteLine(targets[i].GetB());
        Console.WriteLine(targets[i].Request());
    }

    return 0;
}

Main();