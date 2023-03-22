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
        Console.WriteLine("..." + modif);
        if (deep > 1)
        {
            Echooo(modif, deep - 1);
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
    }
}
