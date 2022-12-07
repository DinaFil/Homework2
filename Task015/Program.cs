Console.WriteLine("Введите число, означающее день недели");
int Day = Convert.ToInt32(Console.ReadLine());
int[] Days = {1,2,3,4,5,6,7};
if (Day > Days.Length) Console.WriteLine("Введенное число не соответствует дню недели");
else
{
if (Day > Days[4]) Console.WriteLine("Ура, это выходной!");
else Console.WriteLine("Идем на работу");
}
