using System;

class Program
{ 
    static void Anketa()
    {
        (string name, string surname, int age, string pet) User;
        Console.WriteLine("Введите имя");
        User.name = Console.ReadLine();
        Console.WriteLine("Введите фамилию");
        User.surname = Console.ReadLine();
        Console.WriteLine("Введите возраст");
        User.age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Есть питомец?");
        User.pet = Console.ReadLine();
        if (User.pet == "да")
        {
            Console.WriteLine("Сколько питомцев?");
            int a = Convert.ToInt32(Console.ReadLine());
            Pets(a);
        }
        foreach (var temp in Petsa())
        {
            Console.WriteLine(temp);
        }

        Writ(User.name, User.surname, User.age, User.pet);

    }
    static string[] Pets(int sum)
    {
        var a = new string[sum];
        for (var i = 0; i < sum; i++)
        {
            Console.WriteLine("Введите имя питомца {0}", i + 1);
            a[i] = Console.ReadLine();
        }
        return a;
    }

    static string[] Petsa()
    {
        Console.WriteLine("Сколько любимых цветов?");
        int a = Convert.ToInt32(Console.ReadLine());
        var sum = new string[a];
        for (var i = 0; i < a; i++)
        {
            Console.WriteLine("Введите любимый цвет {0}", i + 1);
            sum[i] = Console.ReadLine();
        }
        return sum;
    }

    static bool Check(string number, out int corrnumber)
    {
        if (int.TryParse(number, out int intnum))
        {
            if (intnum > 0)
            {
                corrnumber = intnum;
                return false;
            }
        }
        {
            corrnumber = 0;
            return true; 
        }
    }

    static void Writ(string a, string b, int c, string d)
    {
        Console.WriteLine("{0} {1} {2} {3}", a, b, c, d);
    }
    static void Main(string[] args)
    {
        Anketa();
    }
}
