using System.Drawing;

class MainClass
{
    static string ShowColor(string username, int userage)
    {
        Console.WriteLine("{0}, {1} год" + "\nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);
        var color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш цвет красный");
                    break;


                case "blue":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш цвет синий");
                    break;


                case "yellow":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш цвет жёлтый");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Множество цветов");
                    break;
            }
            return color;  
    }
    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

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

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        } 

        return result;
    }

    public static void Main(string[] args)
    {
        var (name, age) = ("Захар", 21);
        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);

        Console.WriteLine("Ваше имя: ");
        name = Console.ReadLine();
        Console.WriteLine("Ваш возраст: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);

        var favcolors = new string[3];
        for (int i = 0; i < 3; i++)
        {
            favcolors[i] = ShowColor(name,age);
        }

        Console.WriteLine("Ваши любимые цвета");
        foreach (var fav in favcolors)
        {
            Console.WriteLine(fav);
        }

        GetArrayFromConsole();
    }
}