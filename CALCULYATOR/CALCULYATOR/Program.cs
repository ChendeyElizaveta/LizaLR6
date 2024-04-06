using System;

class CALCULYATOR
{
    static void Main()
    {
        Console.Write("Добро пожаловать. Можете приступать к работе!");
        bool exit = false;

        do
        { 
            try
        {
            Console.WriteLine("Простой калькулятор");

        Console.Write("Введите первое число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
       
        Console.Write("Введите операцию (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
      
        double result = 0;

        switch (operation)
        {
            case '+':
                result = number1 + number2;
                break;
            case '-':
                result = number1 - number2;
                break;
            case '*':
                result = number1 * number2;
                break;
            case '/':
                result = number1 / number2;
            if (number2 != 0)
                {
                    result = number1 / number2;
                }
            else
                {
                    Console.WriteLine("Ошибка: деление на ноль");
            return;
                }
                break;
            default:
                Console.WriteLine("Некорректная операция");
                return;
        }

        Console.WriteLine("Результат: " + result);

        Console.Write("Хотите ли завершить работу? (да/нет): ");
            string finish = Console.ReadLine();

            if (finish.ToLower() == "да")
            {
                exit = true;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введены некорректные данные. Пожалуйста, введите числа.");
        }
        catch (Exception ex)
        {
    Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    } while (!exit);
    }
}  