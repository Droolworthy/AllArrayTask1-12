using System;

namespace AllArrayTask1_12
{
    /// <summary>
    /// Найти минимальный элемент массива
    /// </summary>
    internal class ProgramArray1
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 10, 12, 13, 2, 1, 9, 15, 19, 6 };
            int min = a[0];

            for (int i = 0; i < a.Length; i++)
                if (min > a[i])
                    min = a[i];

            Console.WriteLine(min);
        }
    }
}
/// <summary>
/// Найти два наибольших элемента массива
/// </summary>
internal class ProgramArray2
{
    static void Main(string[] args)
    {
        
        int[] a = new int[] { 5, 17, 16, 2, 1, 9, 15, 19, 6 };
        int max = 0;
        int maxTwo = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > max)
                max = a[i];

        }
        for (int i = 0; i < a.Length - 2; i++)
        {
            if (a[i] > maxTwo)
                maxTwo = a[i];

        }
        Console.WriteLine(max);
        Console.WriteLine(maxTwo);
    }
}
/// <summary>
/// Посчитать сумму элементов массива
/// </summary>
internal class ProgramArray3
{
    static void Main(string[] args)
    {
        {
            int[] a = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine(sum);
        }
    }
}
/// <summary>
/// Заполнить массив по возрастанию от 1 до 100
/// </summary>
internal class ProgramArray4
{
    static void Main(string[] args)
    {
        int[] array = new int[100];

        for (int i = 0; i < array.Length; i++)
        {
            array[i - 1] = i;
        }
    }
}
/// <summary>
/// Создать и заполнить массив случайными целыми числами
/// </summary>
internal class ProgramArray5
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] array = new int[100];

        for (int i = 0; i < array.Length; i++)
        {
            int rand = random.Next(1,10);
            array[i] = rand;
        }
    }
}
/// <summary>
/// Проверить что в массиве нет одинаковых чисел
/// </summary>
internal class ProgramArray6
{
    static void Main(string[] args)
    {
        int[] array = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
        bool result = false;

        for(int i = 0; i < array.Length; i++)
        {
            for(int j = i+1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    result = true;
                    break;
                }
            }
            if (result)
            {
                break;
            }
        }
        Console.WriteLine(result);
    }
}
/// <summary>
/// Переставить элементы массива в обратном порядке используя вспомогательный массив
/// </summary>
internal class ProgramArray7
{
    static void Main(string[] args)
    {
        int[] array = new int[] {5,12,13,2,1,9,15,19,6};
        int[] array2 = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            array2[array2.Length - i - 1] = array[i];
        }
    }
}
/// <summary>
/// Переставить элементы массива в обратном порядке НЕ используя вспомогательный массив
/// </summary>
internal class ProgramArray8
{
    static void Main(string[] args)
    {
        int[] array = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };

        for (int i = 0; i < array.Length / 2; i++)
        {
            int t = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = t;
        }
    }
}
/// <summary>
/// Посчитать сумму чисел в двухмерном массиве
/// </summary>
internal class ProgramArray9
{
    static void Main(string[] args)
    {
        int[,] array = new int[,] { { 5, 12, 13 }, { 5, 1, 3 }, { 5, 12, 13 } };
        int sum = 0;
        int colums = array.GetUpperBound(0) + 1;
        int rows = array.Length / colums;

        for (int i = 0; i < colums; i++)
        {
            for(int j = 0; j < rows; j++)
            {
                sum = sum + array[i, j];
            }
        }
        Console.WriteLine(sum);
    }
}
/// <summary>
/// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 9 и вывести на экран консоли
/// </summary>
internal class ProgramArray10
{
    static void Main(string[] args)
    {
        int size = 10;
        int[,] array = new int[size, size];
        Random random = new Random();
        
        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                int r = random.Next(1, 10);
                array[i, j] = r;
                Console.Write($"{array[i,j]}\t");
            }
            Console.WriteLine();
        }
    }
}
/// <summary>
/// Двумерный массив скопировать в одномерный
/// </summary>
internal class ProgramArray11
{
    static void Main(string[] args)
    {
        int[,] array = new int[,] { { 5, 12, 13 }, { 5, 1, 3 }, { 5, 12, 13 } };
        int[] array2 = new int[array.Length];
        int colums = array.GetUpperBound(0) + 1;
        int rows = array.Length / colums;
        int k = 0;

        for (int i = 0; i < colums; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                array2[k] = array[i, j];
                k++;
            }
        }
    }
}
/// <summary>
/// Двумерный массив скопировать в одномерный
/// </summary>
internal class ProgramArray12
{
    static void Main(string[] args)
    {
        int[,] array = new int[,] { { 5, 12, 13 }, { 5, 1, 3 }, { 5, 12, 13 } };
        int[] array2 = new int[array.Length];
        int colums = array.GetUpperBound(0) + 1;
        int rows = array.Length / colums;
        int k = 0;

        for (int i = 0; i < colums; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                array2[k] = array[i, j];
                k++;
            }
        }
    }
}
/// <summary>
/// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 9 и определить колличество чётных чисел в массиве
/// </summary>
internal class ProgramArray13
{
    static void Main(string[] args)
    {
        int size = 10;
        int[,] array = new int[size, size];
        Random random = new Random();
        int result = 0;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                int r = random.Next(1, 100);
                array[i, j] = r;

                if (r % 2 == 0)
                {
                    result++;
                }
                Console.Write($"{array[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}
/// <summary>
/// Одномерный массив скопировать в двухмерный  4x4
/// </summary>
internal class ProgramArray14
{
    static void Main(string[] args)
    {
        int size = 4;
        int[] m = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[,] a = new int[size, size];
        int k = 0;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                a[i, j] = m[k];
                k++;
                Console.Write($"{a[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}