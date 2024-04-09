namespace Fibonachi;

class Program
{
    static void Main(string[] args)
    {
        int fibPos;
        long fibNumber;

        Console.Write("Введите номер позиции: ");
        fibPos = Convert.ToInt32(Console.ReadLine());

        fibNumber = GetFibNumber(fibPos);

        Console.WriteLine(fibNumber);

        long GetFibNumber(int pos) {
            long result = 0;

            if (pos == 0)
                return 0;
            else if (pos == 1)
                return 1;

            
            result = GetFibNumber(pos - 1) + GetFibNumber(pos - 2);
                 

            return result;
        }
    }

    
}
