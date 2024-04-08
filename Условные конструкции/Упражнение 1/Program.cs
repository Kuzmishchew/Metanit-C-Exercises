string input;
int firstNum;
int secondNum;

Console.Write("Введите первое число для сравнения: ");
input = Console.ReadLine();
firstNum = Convert.ToInt32(input);

Console.Write("Введите второе число для сравнения: ");
input =  Console.ReadLine();
secondNum = Convert.ToInt32(input);


if (firstNum > secondNum)
    Console.WriteLine("Первое число больше второго.");
else if (firstNum < secondNum)
    Console.WriteLine("Второе число больше первого.");
else
    Console.WriteLine("Оба числа равны.");

Console.ReadKey();