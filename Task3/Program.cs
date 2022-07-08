/* Задача 3: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3, 7, 22, 2, 78] -> 76
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

int FindMax(int[] array)     //Функция поиска максимума в массиве
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

int FindMin(int[] array)     //Функция поиска минимума в массиве
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}


int[] array = GenerateArray(4, 0, 99);
PrintArray(array);
System.Console.WriteLine();

System.Console.WriteLine($"Разница между максимальным элементом массива {FindMax(array)} и минимальным элементом масива {FindMin(array)} равна {FindMax(array) - FindMin(array)}");
//System.Console.WriteLine($"Сумма нечетных элементов в массиве равна {OddsElementsSum(array)}");