/*
Перепишите предыдущую программу, только вместо цикла for используйте цикл while.

За каждый месяц банк начисляет к сумме вклада 7% от суммы. 
Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев. 
А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
*/
namespace Упражнение_2;

class Program
{
    static void Main(string[] args)
    {
        decimal deposit;
        int     monthCount;

        Console.WriteLine("Введите сумму вклада: ");
        deposit = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Введите срок вклада в месяцах: ");
        monthCount = Convert.ToInt32(Console.ReadLine());

        while (monthCount > 0)
        {
            deposit *= 1.07m;
            --monthCount;
        }

        Console.WriteLine($"Сумма вклада после депозита: {Math.Round(deposit, 2)}");

        Console.ReadKey();
    }
}
