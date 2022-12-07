Console.WriteLine("Введите любое число: ");
string ABC = Console.ReadLine();
int x = ABC.Length;
if (x < 3) Console.WriteLine ("В заданном числе отсутсвует третья цифра");
else Console.WriteLine(ABC[2]);
