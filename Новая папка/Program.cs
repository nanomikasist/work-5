/*задание1------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 3 == 0 && number % 7 == 0)
            {
                Console.WriteLine("Число " + number + " делится на 3 и на 7.");
            }
            else
            {
                Console.WriteLine("Число " + number + " не делится на 3 и на 7.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка! Введено некорректное значение.");
        }
    }
}*/
/*задание2------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите первое число:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine("Первое число больше второго.");
            }
            else if (number1 < number2)
            {
                Console.WriteLine("Второе число больше первого.");
            }
            else
            {
                Console.WriteLine("Числа равны.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка! Введено некорректное значение.");
        }
    }
}
*/
/*задание3------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
class Program
{
    static void Main()
    {
        try
        {
            int sum = 0; int number;
            do
            {
                Console.WriteLine("Введите число (для выхода введите 0):");
                number = Convert.ToInt32(Console.ReadLine()); 
                sum += number;
            } while (number != 0);
            Console.WriteLine("Сумма чисел: " + sum);
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка! Введено некорректное значение.");
        }
    }
}
*/
/*задание4------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите число от 1 до 7:"); 
            int number = Convert.ToInt32(Console.ReadLine());
            string day;
            switch (number)
            {
                case 1:
                    day = "Понедельник"; 
                   break;
                case 2:
                    day = "Вторник";
                    break;
                case 3:
                    day = "Среда";
                    break;
                case 4:
                    day = "Четверг";
                    break;
                case 5:
                    day = "Пятница";
                    break;
                case 6:
                    day = "Суббота";
                    break;
                case 7:
                    day = "Воскресенье";
                    break;
                default: throw new Exception();
            }
            Console.WriteLine("День недели: " + day);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка! Введено некорректное числовое значение.");
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка! Введено некорректное значение.");
        }
    }
}
*/
/*задание5------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите название дня недели: ");
        string dayName = Console.ReadLine();
        dayName = dayName.ToLower();
        int dayNumber;
        switch (dayName)
        {
            case "понедельник":
                dayNumber = 1;
                break;
            case "вторник":
                dayNumber = 2;
                break;
            case "среда":
                dayNumber = 3;
                break;
            case "четверг":
                dayNumber = 4;
                break;
            case "пятница":
                dayNumber = 5;
                break;
            case "суббота":
                dayNumber = 6;
                break;
            case "воскресенье":
                dayNumber = 7;
                break;
            default:
                Console.WriteLine("Такого дня нет в неделе.");
                return;
        }
        Console.WriteLine($"Порядковый номер дня {dayName}: {dayNumber}");
    }
}
*/
/*задание6------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество чисел: ");
        int count = int.Parse(Console.ReadLine());

        int prev1 = 1;
        int prev2 = 1;

        Console.Write("Последовательность чисел Фибоначчи: ");

        Console.Write(prev1 + " ");
        Console.Write(prev2 + " ");

        for (int i = 2; i < count; i++)
        {
            int current = prev1 + prev2;

            Console.Write(current + " ");

            prev1 = prev2;
            prev2 = current;
        }
    }
}
*/
/*задание7------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите первое целое число:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе целое число:");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 <= num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                for (int i = num2; i <= num1; i++)
                {
                    Console.Write(i + " ");
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено некорректное значение.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}
*/
/*задание8------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите количество чисел для суммирования:");
            int count = int.Parse(Console.ReadLine());

            int sum = 0;
            int num = 1;

            while (count > 0)
            {
                if (num % 5 == 2 || num % 3 == 1)
                {
                    sum += num;
                    Console.Write(num + " ");
                    count--;
                }

                num++;
            }

            Console.WriteLine("\nСумма чисел: " + sum);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено некорректное значение.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}
*/
//задание9------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите значение n: "); 
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Ошибка: Введите положительное значение n."); 
                return;
            }
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Сумма четных чисел от 2 до {2 * n}: {sum}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введите целое число.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
