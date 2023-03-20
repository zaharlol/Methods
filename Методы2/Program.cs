using System;
using System.Drawing;

class MainClass
{

    static int[] GetArrayFromConsole(int num = 5)
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        return result;
    }

    static int[] SortArray(int[] result)
    {
        int temp;
        for (int z = 0; z < result.Length; z++)
        {
            for (int j = z + 1; j < result.Length; j++)
            {
                if (result[z] > result[j])
                {
                    temp = result[z];
                    result[z] = result[j];
                    result[j] = temp;
                }
            }
        }
        return result;
    }

    static void ShowArray(int[] array, bool sort = false)
    {
        var temp = array;
        if (sort)
        {
            temp = SortArray(array);
        }

        foreach (var item in temp)
        {
            Console.WriteLine(item);
        }
    }

    public static void Main(string[] args)
    {

        var array = GetArrayFromConsole();
        ShowArray(array, true);
    }
}