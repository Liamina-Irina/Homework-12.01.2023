// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// array[0] = 1;
// array[1] = 0;
// array[2] = 1;
// array[3] = 1;
// array[4] = 0;
// array[5] = 1;
// array[6] = 0;
// array[7] = 0;

// FillArray(array);
// PrintArray(array);

int[] array = CreateArray(8);
PrintArray(array);

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
    arr[i] = rnd.Next(0, 34); 
    }
}

int[] PrintArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
    Console.Write(arr[i] + " ,"); 
    }
}
Console.WriteLine(); 