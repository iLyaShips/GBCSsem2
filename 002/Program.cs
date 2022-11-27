// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int x = num;
int count = 0;
while (x > 0)
{
    x = x / 10;
    count++;
}
if (count <= 2) Console.WriteLine("Третьей цифры нет");
else
{
    while (count > 3)
    {
        num = num / 10;
        count--;
    }
    Console.WriteLine($"Вывод: {num % 10}");
}
