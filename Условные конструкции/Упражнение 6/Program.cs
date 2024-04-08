namespace Упражнение6;

class Program
{
    static void Main(string[] args)
    {
        byte operationNumber;

        Console.WriteLine("Введите номер операции: \n 1 — Сложение \n 2 — Вычитание \n 3 — Умножение");
        Console.Write("Номер операции: ");
        operationNumber = Convert.ToByte(Console.ReadLine());

        Console.Write("Вы выбрали — ");
        switch (operationNumber) {
            case 1:
                Console.Write("Сложение");
                break;
            case 2:
                Console.Write("Вычитание");
                break;
            case 3:
                Console.Write("Умножение");
                break;
            default:
                Console.Write("Неопределенную операцию");
                break;
        }

        Console.ReadKey();

    }
}
