string input;
int num;

Console.Write("Введите число для проверки: ");
input = Console.ReadLine();
num = Convert.ToInt32(input);

if (num > 5 && num < 10)
    Console.WriteLine("Число больше 5 и меньше 10.");
else
    Console.WriteLine("Неизвестное число.");

Console.ReadKey();
