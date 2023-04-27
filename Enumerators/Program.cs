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
