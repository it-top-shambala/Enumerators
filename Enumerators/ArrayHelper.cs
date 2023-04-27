namespace Enumerators;

public static class ArrayHelper
{
    public static void RandomFill(int[] array, int beginRandom, int endRandom)
    {
        var random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(beginRandom, endRandom + 1);
        }
    }

    public static void Print(int[] array)
    {
        Console.Write("[ ");
        foreach (var item in array)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("]");
    }
}