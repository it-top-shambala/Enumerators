using Enumerators;

const int BEGIN_RANDOM = -10;
const int END_RANDOM = 10;

int size;
Console.Write("Введите количество элементов: ");
size = Convert.ToInt32(Console.ReadLine());
var array = new int[size];

ArrayHelper.RandomFill(array, BEGIN_RANDOM, END_RANDOM);
ArrayHelper.Print(array);

var list = new List<int>();
ListHelper.RandomFill(list, size, BEGIN_RANDOM, END_RANDOM);
ListHelper.Print(list);

EnumeratorHelper.Print(array);
EnumeratorHelper.Print(list);

Array.Sort(array);
Array.Sort(list.ToArray());

EnumeratorHelper.Print(array);
EnumeratorHelper.Print(list);
var average = list.Average();
Console.WriteLine($"Average = {average}");

var distinctArray = array.Distinct();
EnumeratorHelper.Print(distinctArray);

var result = array.Distinct().Skip(3).Take(5);
EnumeratorHelper.Print(result);

