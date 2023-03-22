using System;

class MainClass
{
    static void Echooo(string saidworld, int deep)
    {
        var modif = saidworld;
        if (modif.Length > 2)
        {
            modif = modif.Remove(0, 2);
        }

        Console.BackgroundColor = (ConsoleColor)deep;
        Console.WriteLine("..." + modif);

        if (deep > 1)
        {
            Echooo(modif, deep - 1);
        }
    }

    static decimal Factorial(int x)
    {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }

    private static int PowerUp(int N, byte pow)
    {
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow == 1)
                {
                    return N;
                }
                else
                {
                    return N * PowerUp(N, --pow);
                }
            }
        }
    }



    static void Main(string[] args)
    {
        Console.WriteLine("Напишите что-то");
        var str = Console.ReadLine();

        Console.WriteLine("Укажите глубину эха");
        var deep = int.Parse(Console.ReadLine());

        Echooo(str, deep);

        Console.ReadKey();

        Console.WriteLine("Введие число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень");
        byte b = Convert.ToByte(Console.ReadLine());
        PowerUp(a, b);
    }
}