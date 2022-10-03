/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.Clear();

int length = 5;
double[] array = FillArray(length);
Console.Write($"[{String.Join(" ", array)}]");
Console.WriteLine();
Console.WriteLine($"Difference between max and min numbers is equal to {MaxMInDifference(array)}");

double[] FillArray(int length)
{
    double[] arr = new double[length];
    Random randGenerator = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(randGenerator.NextDouble() * 10 - 5, 1);
    }
    return arr;
}

double MaxMInDifference(double[] arr)
{
    double maxNumber = arr[0];
    double minNumber = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (array[i] < minNumber)
            minNumber = arr[i];

        else if (array[i] > maxNumber)
            maxNumber = arr[i];
    }
    double diff = Math.Round(maxNumber - minNumber, 1);
    return diff;
}
