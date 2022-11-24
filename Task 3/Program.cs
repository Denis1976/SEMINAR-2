Console.WriteLine("Кратно ли число одновременно 7 и 23?");
Console.WriteLine("Введите число больше 23 ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 ==0 && a % 23 == 0)
    Console.WriteLine("Отлично! Кратно! ");
else
    Console.WriteLine("Не кратно! Попробуй еще раз!");