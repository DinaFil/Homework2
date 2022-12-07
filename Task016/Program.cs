Console.WriteLine("Пожалуйста, введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int x = number1/number2;
int y = number2/number1;
if (x == number2 || y == number1) Console.WriteLine("Одно число является квадратом другого");
else Console.WriteLine("Одно число не является квадратом другого");
