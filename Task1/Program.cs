/* Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
 */

int[] GenerateArray(int lenght, int min, int max) //Создание массива и заполнение его рандомными элементами...
{
    int[] newArray = new int[lenght];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max + 1);
    }
    return newArray;
}

void PrintArray(int[] array)    //Вывод созданого массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int PositiveNumber(int[] array)     //Функция поиска кол-ва четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int[] array = GenerateArray(5, 100, 999);
PrintArray(array);
System.Console.WriteLine();

System.Console.WriteLine($"Количество четных чисел в массиве равно {PositiveNumber(array)}");