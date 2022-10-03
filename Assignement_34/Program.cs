/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Console.Clear();
Console.WriteLine("Enter postitive 3-digit numbers for array");
string numbers = Console.ReadLine()!;

int[] arr = StringToArray(numbers);
Console.WriteLine($"Quantity of even numbers in the array is equal to {EvenNumbers(arr)}");

int[] StringToArray(string str)
{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }
    return result;
}
int EvenNumbers(int[] array)
{

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}


