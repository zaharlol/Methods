using System;
using System.Net.Security;
using System.Reflection;
using System.Xml.Linq;

class Program
{
    private static void Main(string[] args)
    {
        (string name, string[] dishes) User;

        Console.WriteLine("Введите ваше имя");
        User.name = Console.ReadLine();

        Console.WriteLine("Введите 5 любимых блюд");
        User.dishes = new string[5];
        for (int i = 0; i < 5; i++)
        {
            User.dishes[i] = Console.ReadLine();
        }
    }
}