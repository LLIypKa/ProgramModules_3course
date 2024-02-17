using Observer;

int n = 5;
string S = "ABCDEFGHIJ";
ConcreteSubject subj = new ConcreteSubject();
List<ConcreteObserver> observers = new List<ConcreteObserver>();

for (int i = 0; i < n; i++)
{
    observers.Add(new ConcreteObserver(S[i], subj));
    observers[i].Attach();
}

for(int i = 0; i < S.Length; i++)
{
    subj.SetState((char)S[i]);
   // Console.WriteLine(subj.GetState());
}

for (int i = 0; i < n; i++) Console.WriteLine(observers[i].GetLog());