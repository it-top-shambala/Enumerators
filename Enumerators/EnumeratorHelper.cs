namespace Enumerators;

public static class EnumeratorHelper
{
    public static void Print(IEnumerable<int> enumerable)
    {
        Console.Write("< ");
        foreach (var item in enumerable)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine(">");
    }
}