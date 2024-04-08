using System.ComponentModel.Design.Serialization;

namespace Упражнение3;

class Program
{
    static void Main(string[] args)
    {
        string input;
        int number;

        Console.Write("Введите число для проверки: ");

        input = Console.ReadLine();
        number = Convert.ToInt32(input);

        if (number == 5 || number == 10)
            Console.WriteLine("Число либо равно 5, либо равно 10.");
        else
            Console.WriteLine("Неизвестное число.");

        Console.ReadKey();
    }

    
}
