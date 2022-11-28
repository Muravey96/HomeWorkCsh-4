/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.Clear();
int length = 8;
int[] array = new int[length];

FillArrayN(array);
PrintArray(array);

/////////////

void FillArrayN(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 20);
    }

}

/////////////

void PrintArray(int[] array)
{
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write($"]");
}

