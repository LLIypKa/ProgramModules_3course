namespace Decorator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numForTest;
            //int testCount;
            List<Function> functions = new List<Function>();
            FX fX = new FX();
            FDouble fD = new FDouble(fX);

            numForTest = Int32.Parse(Console.ReadLine());
            //testCount = Int32.Parse(Console.ReadLine());
            functions.Add(new FDouble(fD));
            functions.Add(new FTripple(fD));
            functions.Add(new FSquare(fD));
            functions.Add(new FCube(fD));

            Console.WriteLine(functions.Count());

            foreach (Function f in functions)
            {
                Console.WriteLine($"{f.GetName()} = {f.GetValue(numForTest)}");
            }
        }
    }
}