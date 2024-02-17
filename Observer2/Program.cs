using Observer2;

int n = 5;
int k = 5;
string[] strings = new string[] { "1a", "2b", "1c", "2d", "1e" };
ConcreteSubject subject1 = new ConcreteSubject();
ConcreteSubject subject2 = new ConcreteSubject();
List<ConcreteObserver>  observers = new List<ConcreteObserver>();

for(int i = 0; i < n; i++)
{
    observers.Add(new ConcreteObserver(strings[i][1]));
}
for(int i = 0; i < n; i++)
{
    observers[i].Attach(subject1);
    observers[i].Attach(subject2);
}
for(int i = 0; i<n;i++)
{
    if (strings[i][0] == '1') subject1.SetState(strings[i]);
    else subject2.SetState(strings[i]);
}
for(int i = 0; i < n; i++)
{
    Console.WriteLine(observers[i].GetLog());
}