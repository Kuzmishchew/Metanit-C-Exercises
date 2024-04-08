namespace Упражнение5;

class Program
{
    static void Main(string[] args)
    {
        double sum;

        Console.Write("Введите сумму вклада: ");
        sum = Convert.ToDouble(Console.ReadLine());

        if (sum < 100)
            sum += sum * 0.05;
        else if (sum <= 200)
            sum += sum * 0.07;
        else 
            sum += sum * 0.1;

        sum += 15;

        Console.WriteLine($"Сумма вклада с процентами: {sum}");

        Console.ReadKey();
    }
}
