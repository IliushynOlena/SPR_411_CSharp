//Task 1

//using System;

//namespace _1_Practical
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");
//        }
//    }
//}

//Task 2

//using System;

//namespace _1_Practical
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введіть 5 чисел:");

//        Console.Write("Число 1: ");
//        double a = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Число 2: ");
//        double b = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Число 3: ");
//        double c = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Число 4: ");
//        double d = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Число 5: ");
//        double e = Convert.ToDouble(Console.ReadLine());

//        double sum = a + b + c + d + e;
//        double product = a * b * c * d * e;

//        double max = a;
//        if (b > max) max = b;
//        if (c > max) max = c;
//        if (d > max) max = d;
//        if (e > max) max = e;

//        double min = a;
//        if (b < min) min = b;
//        if (c < min) min = c;
//        if (d < min) min = d;
//        if (e < min) min = e;

//        Console.WriteLine("\nРезультати обчислень:");
//        Console.WriteLine($"Сума чисел: {sum}");
//        Console.WriteLine($"Добуток чисел: {product}");
//        Console.WriteLine($"Максимальне число: {max}");
//        Console.WriteLine($"Мінімальне число: {min}");
//    }
//}


// Task 3

using System;

namespace _1_Practical

    {
    class Program
    {
        static void Main()
        {
            Console.Write("Введіть шестизначне число: ");
            string str  = Console.ReadLine()!;
            Console.WriteLine(str);

            if (str.Length != 6 || !int.TryParse(str, out _))
            {
                Console.WriteLine("Помилка: введене значення не є шестизначним числом.");
                return;
            }
            else
            {
                char[] chars = str.ToCharArray();
                Array.Reverse(chars);
                string reversed = new string(chars);

                Console.WriteLine($"Перевернуте число: {reversed}");

            }
         
        }
    }
}
