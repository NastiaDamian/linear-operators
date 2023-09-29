
using System;
using System.Formats.Asn1;

internal class Program
{
    static void Main(string[] args)
    {
        // Завдання 1 
         int number1;
         int number2;

         Console.WriteLine("Введіть число для дня");
         number1 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Введіть число для місяця");
         number2 = Convert.ToInt32(Console.ReadLine());

         string result = (number1 > 0) && (number1 <= 31) && (number2 > 0) && (number2 <= 12) ?
             "Ці числа можуть бути днем та місяцем" : "Ці числі не можуть бути днем та місяцем";
         Console.WriteLine(result);

        // Завдання 2 
        Console.WriteLine("Введіть дійсне число");
         double a = double.Parse(Console.ReadLine());
         var x = (a * 10) % 10;
         var y = (a * 100) % 10;
         int sum = (int)(x + y);
         Console.WriteLine(sum);

         // Завдання 3 
         int h;
         Console.WriteLine("Введіть час дня у годинах (ціле число)");
         h = Convert.ToInt32(Console.ReadLine());
         if ( h >= 5 & h<= 11 )
         { Console.WriteLine("Доброго ранку"); }
         else if (h >=11 & h <= 17) 
         { Console.WriteLine("Добрий день"); }
         else if (h >= 17 & h <= 21)
         { Console.WriteLine("Добрий вечір"); }
         else if (h >= 21 & h <= 24)
         { Console.WriteLine("Доброї ночі"); }
         else
             if ( h > 24) { Console.WriteLine("Не існує такої години"); }

         //Завдання 4
         int num1, num2, num3;

         Console.WriteLine("Введіть перше число: ");
         num1 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Введіть друге число: ");
         num2 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Введіть третє число: ");
         num3 = Convert.ToInt32(Console.ReadLine());

         int max = Math.Max(num1, Math.Max(num2, num3));
         int min = Math.Min(num1, Math.Min(num2, num3));

         Console.WriteLine($"Максимальне число: {max}");
         Console.WriteLine($"Мінімальне число: {min}");

        //Завдання 5 
        double j;
        double b;
        Console.WriteLine("Введіть довжину прямокутника");
        j = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть ширину прямокутника");
        b = Convert.ToDouble(Console.ReadLine());
        double area = j * b;
        Console.WriteLine($"Площа трикутника дорівнює: { area }" );

        //Завдання 6 

        Console.WriteLine("Введіть число(ціле)");
        int numb;
        numb = Convert.ToInt32(Console.ReadLine());
        if (numb % 2 == 0)
        { Console.WriteLine("Число парне "); }
        else { Console.WriteLine("Число непарне "); }

        //Завдання 7 

        Console.WriteLine("Введіть число в градусах Цельсія");
        double degree;
        degree = Convert.ToDouble(Console.ReadLine());
        double fahr = (degree *9/5) + 32;
        Console.WriteLine($"Градуси Фаренгейта {fahr} ");

        //Завдання 8 

        Console.Write(" Введiть значення n: ");
        int n;
        n= Convert.ToInt32(Console.ReadLine());
        int sumNumbers = (n * (n + 1)) / 2;
        Console.WriteLine($"Сума перших {n} натуральних чисел: {sumNumbers}");






    }
}

