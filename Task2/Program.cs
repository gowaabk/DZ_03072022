/* Задача 2: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 4, 67] -> 0
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

int OddsElementsSum(int[] array)     //Функция суммы нечетных элементов в массиве
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int[] array = GenerateArray(4, 0, 99);
PrintArray(array);
System.Console.WriteLine();

System.Console.WriteLine($"Сумма нечетных элементов в массиве равна {OddsElementsSum(array)}");