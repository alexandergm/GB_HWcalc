class Calculator
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите операцию (+, -, *, /): ");
        char operation = char.Parse(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case '+':
                result = a + b;
                break;
            case '-':
                result = a - b;
                break;
            case '*':
                result = a * b;
                break;
            case '/':
                result = a / b;
                break;
            default:
                Console.WriteLine("Операция не распознана.");
                break;
        }

        Console.WriteLine("Результат: " + result);
    }
}
