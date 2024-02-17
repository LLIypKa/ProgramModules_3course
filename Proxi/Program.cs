using Proxi;
using System.Security.Cryptography.X509Certificates;

void Main()
{
    int[] arr = new int[4];
    string commands = "ABCD";
    Subject[] subjects = new Subject[4]; 

    for(int i = 0; i < 4; i++)
    {
        arr[i] = i;
    }

    for (int i = 0; i < 4; i++)
    {
        if (arr[i] == 0)
        {
            subjects[i] = new Proxy(false, false);
        }
        else if (arr[i] == 1)
        {
            subjects[i] = new Proxy(true, false);
        }
        else if (arr[i] == 2)
        {
            subjects[i] = new Proxy(false, true);
        }
        else subjects[i] = new Proxy(true, true);

        Console.WriteLine($"{i}\n{subjects[i].RequestA()}" +
            $"\n{subjects[i].RequestB()}\n{subjects[i].RequestC()}\n{subjects[i].RequestD()}\n");
    }

}

Main();