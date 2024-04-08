/* 
За каждый месяц банк начисляет к сумме вклада 7% от суммы. 
Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев. А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.

Для вычисления суммы с учетом процентов используйте цикл for. Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine()) (сумма вклада будет представлять тип decimal).
*/
namespace Упражнение_1;

class Program
{
    static void Main(string[] args)
    {   
        decimal     deposit;
        int         monthCount;        

        Console.WriteLine("Введите сумму вклада: ");
        deposit = Convert.ToDecimal(Console.ReadLine());
        
        Console.WriteLine("Введите срок вклада в месяцах: ");
        monthCount = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < monthCount; i++) 
            deposit *= 1.07m;
        
        Console.WriteLine($"Сумма вклада после начисления процентов: {Math.Round(deposit, 2)}");
        
        Console.ReadKey();
    }
}
