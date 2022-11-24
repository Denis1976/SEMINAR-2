Console.WriteLine("Введите 2 целых числа");
int a = Convert.ToInt32(Console.ReadLine ());
int b = Convert.ToInt32(Console.ReadLine ());
if (a % b == 0)
Console.WriteLine("Кратно! Отлично!");
else
Console.WriteLine($"Не кратно! Остаток = {a % b}");
