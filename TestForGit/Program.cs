while (true)
{
    Console.WriteLine("Первое число.");
    var firstNumber = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Математическая операция:\n +\n -\n *\n /\n");
    var operation = Console.ReadLine();

    Console.WriteLine("Второе число.");
    var secondNumber = Convert.ToDouble(Console.ReadLine());

    double result;
    switch (operation)
    {
        case "+":
            result = firstNumber + secondNumber;
            Console.WriteLine("Результат: " + result);
            break;
        case "-":
            result = firstNumber - secondNumber;
            Console.WriteLine("Результат: " + result);
            break;
        case "*":
            result = firstNumber * secondNumber;
            Console.WriteLine("Результат: " + result);
            break;
        case "/":
            result = firstNumber / secondNumber;
            Console.WriteLine("Результат: " + result);
            break;
        default:
            Console.WriteLine("Выбрана неверная операция.");
            break;
    }
}