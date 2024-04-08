namespace Упражнение7;

class Program
{
    static void Main(string[] args)
    {
        byte    operationNumber;
        int     firstNumber;
        int     secondNumber;
        
        Console.Write("Введите первое число: ");
        firstNumber = Convert.ToInt32(Console.ReadLine());  
        
        Console.Write("Введите второе число: ");
        secondNumber = Convert.ToInt32(Console.ReadLine()); 
        
        Console.WriteLine("Операция согласно номеру: \n 1 — Сложение \n 2 — Вычитание \n 3 — Умножение");        
        Console.Write("Введите номер операции: ");
        operationNumber = Convert.ToByte(Console.ReadLine());   
        
        switch (operationNumber)
        {
            case 1:
                Console.WriteLine($"Результат выполнения операции: {firstNumber + secondNumber}");
                break;
            case 2:     
                Console.WriteLine($"Результат выполнения операции: {firstNumber - secondNumber}");
                break;
            case 3:
                Console.WriteLine($"Результат выполнения операции: {firstNumber * secondNumber}");
                break;
            default:
                Console.WriteLine("Вы выбрали неизвестную операцию.");
                break;
        }

        Console.ReadKey();            
    }
}
