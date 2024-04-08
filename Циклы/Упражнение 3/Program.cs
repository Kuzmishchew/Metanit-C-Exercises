/*
Напишите программу, которая выводит на консоль таблицу умножения/
*/
namespace Упражнение_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Таблица умножения \n");

        for (int i = 1; i <= 9; i = i + 3)
        {
            for (int j = 1; j <= 9; ++j) 
            {
                for (int c = 0; c < 3; ++c)
                    Console.Write($"{i + c} * {j} = {(i + c) * j}\t");
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        Console.ReadKey();
    }
}
