using Bridge;

void Main()
{
    int size;
    string caption;
    int[] newSizes = new int[5];
    Abstraction abstractionA;
    Abstraction abstractionB;
    RefinedAbstraction refinedAbstractionA;
    RefinedAbstraction refinedAbstractionB;

    size = Int32.Parse(Console.ReadLine());
    caption = Console.ReadLine();

    abstractionA = new Abstraction(new ConcreteImplementorA(), size);
    abstractionB = new Abstraction(new ConcreteImplementorB(), size);
    refinedAbstractionA = new RefinedAbstraction(new ConcreteImplementorA(), size, caption);
    refinedAbstractionB = new RefinedAbstraction(new ConcreteImplementorB(), size, caption);

    Console.WriteLine($"aA:\n{abstractionA.Show()}\naB:\n{abstractionB.Show()}");
    Console.WriteLine($"raA:\n{refinedAbstractionA.Show()}\nraB:\n{refinedAbstractionB.Show()}");

    for(int i = 0; i < newSizes.Length; i++)
    {
        newSizes[i] = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"new size = {newSizes[i]}");
        abstractionA.SetSize(newSizes[i]);
        abstractionB.SetSize(newSizes[i]);
        refinedAbstractionA.SetSize(newSizes[i]);
        refinedAbstractionB.SetSize(newSizes[i]);

        Console.WriteLine($"aA:\n{abstractionA.Show()}\naB:\n{abstractionB.Show()}");
        Console.WriteLine($"raA:\n{refinedAbstractionA.Show()}\nraB:\n{refinedAbstractionB.Show()}");
    }

    return;
}

Main();