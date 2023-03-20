using System;
using System.Drawing;
using System.Globalization;

class MainClass
{
    static void ChangeAge(ref int age)
    {
        age = Int32.Parse(Console.ReadLine());
        Console.WriteLine(age);
    }

    static void BigDataOperation( in int[] arr)
    {
        arr[0] = 4;
    }

    static int[] GetArrayFromConsole(ref int num)
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        return result;
    }

    static void SortArray(in int[] array, out int[] sortasc, out int[] sortdesc)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        sortasc = SortArrayAsc(array);
        foreach (int i in sortasc)
        {
            Console.WriteLine(i);
        }
        sortdesc = SortArrayDesc(array);
        foreach (int i in sortdesc)
        {
            Console.WriteLine(i);
        }

    }

    static int[] SortArrayAsc(int[] result)
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

    static int[] SortArrayDesc(int[] result)
    {
        int temp;
        for (int z = 0; z < result.Length; z++)
        {
            for (int j = z + 1; j < result.Length; j++)
            {
                if (result[z] < result[j])
                {
                    temp = result[z];
                    result[z] = result[j];
                    result[j] = temp;
                }
            }
        }
        return result;
    }

    public static void Main(string[] arg)
    {
        int[] c = new int[5];
        SortArray(in c, out c, out c);
    }
}