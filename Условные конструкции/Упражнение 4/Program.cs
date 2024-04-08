namespace Упражнение4;

class Program
{
    static void Main(string[] args)
    {
        double number;
        double result;

        Console.Write("Введите сумму для расчета процентов: ");
        number = Convert.ToDouble(Console.ReadLine());

        if (number < 100)
            result = number * 1.05;
        else if (number <= 200)
            result = number * 1.07;
        else 
            result = number * 1.1;

        Console.WriteLine($"Сумма вклада с процентами: {result}");

        Console.ReadKey();
    }
}
