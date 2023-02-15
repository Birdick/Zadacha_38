// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void MinMaxDiff(int[] myArray, int minVal, int maxVal)
{
    int numMin = myArray[0];
    int numMax = myArray[0];
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] < numMin)
        {
            numMin = myArray[i];
        }
        if (myArray[i] > numMax)
        {
            numMax = myArray[i];
        }
    }
    Console.WriteLine($"The difference between min Value and max Value is {numMax - numMin}");
}

Console.Write("Enter the massive size: ");
int size = int.Parse(Console.ReadLine()!);
Console.Write("Enter the minimum massive number: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Enter the maximum massive number: ");
int max = int.Parse(Console.ReadLine()!);
int[] Array = GetArray(size, min, max);
Console.WriteLine($"[{string.Join(", ", Array)}]");
MinMaxDiff(Array, min, max);