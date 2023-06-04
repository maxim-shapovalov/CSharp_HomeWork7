// Задача 47 начало
double[,] FillArray(int m, int n)

{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10 ;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}
// Задача 47 конец

// Задача 50 начало
void FindPosition(double[,] array, double x)
{
    Boolean flag = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == x) 
            {
                Console.Write($"Введенное число есть в массиве в строке {i + 1} столбце {j + 1}\n");
                flag = true;
            }
            
        }        
    }
    if (flag == false) Console.WriteLine("Введенное число в массиве не найдено");
}
// Задача 50 конец


// Задача 52 начало
int[,] FillArray3(int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray3(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

void FindMedium(int[,] array)
{   //Console.Write($"сумма значений по столбцам ");
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int count = 0;
        double medium = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            count += array[j, i];
        }
        medium = Convert.ToDouble(count) / Convert.ToDouble(array.GetLength(0));
        Console.Write($"{Math.Round(medium, 2)}  ");
        //Console.Write($"{count} ");
    }
}
// Задача 52 конец


Console.Clear();
Console.WriteLine("\n========= Список задач ==========\n");
Console.WriteLine("1 - Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
Console.WriteLine("2 - Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("3 - Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine("0 - Выход\n");
Console.Write("Выберите задачу 1, 2 или 3:   ");
int task = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

switch (task)
{
    case 1:
        // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
        // m = 3, n = 4.
        // 0,5 7 -2 -0,2
        // 1 -3,3 8 -9,9
        // 8 7,8 -7,1 9
        int m = 3;
        int n = 4;
        double[,] array = FillArray(m, n);
        PrintArray(array);
        break;

    case 2:
        // Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 17 -> такого числа в массиве нет
        double[,] array2 = FillArray(3, 4);
        PrintArray(array2);
        Console.Write("Введите число ");
        double x = Convert.ToDouble(Console.ReadLine());
        FindPosition(array2, x);
        break;

    case 3:
        // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
        int[,] array3 = FillArray3(3, 4);
        PrintArray3(array3);
        FindMedium(array3);
        break;    


    case 0:
        Console.WriteLine("Всего хорошего!");
        break;
}
Console.WriteLine();