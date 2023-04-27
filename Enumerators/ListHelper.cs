namespace Enumerators;

public static class ListHelper
{
    public static void RandomFill(List<int> list, int size, int beginRandom, int endRandom)
    {
        for (int i = 0; i < size; i++)
        {
            list.Add(i);
        }
    }

    public static void Print(List<int> list)
    {
        /*
         * for (int i = 0; i < list.Count; i++)
         * {
         *      Console.Write($"{list[i]} ");
         * }
         * Console.WriteLine();
         */

        Console.Write("| ");
        foreach (var item in list)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("|");
    }
}