using System;

class Calculator
{
    static void Main()
    {
        double num1, num2;
        char operation;

        Console.WriteLine("Prosty kalkulator");

        Console.Write("Podaj pierwszą liczbę: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Wybierz operację (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Nie można dzielić przez zero!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Nieprawidłowa operacja!");
                return;
        }

        Console.WriteLine("Wynik: " + result);
    }
}
