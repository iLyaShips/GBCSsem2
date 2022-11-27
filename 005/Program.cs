﻿// Задача 2:
// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов 
// написали для него программу, по которой робот, когда заходит в комнату, считает количество 
// программистов в ней и произносит его вслух: "n программистов".
// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), 
// выводящее это число в консоль вместе с правильным образом изменённым словом "программист", 
// для того, чтобы робот мог нормально общаться с людьми, например: 
// 1 программист, 2 программиста, 5 программистов.
// В комнате может быть очень много программистов. Проверьте, что ваша программа 
// правильно обработает все случаи, как минимум до 1000 человек.

void ProgrammerLot(int num)
{
    string result = $"{num} программист";
    if (num < 0) result = "Ошибка! Введите положительное число.";
    else if (num == 0) result += "ов";
    else if (num == 1 | num == 21 | num == 31 | num == 41 | num == 51 | num == 61 | num == 71 | num == 81 | num == 91) result += "";
    else if (num >= 2 && num <= 4) result += "а";
    else if (num >= 22 && num <= 24) result += "а";
    else if (num >= 32 && num <= 34) result += "а";
    else if (num >= 42 && num <= 44) result += "а";
    else if (num >= 52 && num <= 54) result += "а";
    else if (num >= 62 && num <= 64) result += "а";
    else if (num >= 72 && num <= 74) result += "а";
    else if (num >= 82 && num <= 84) result += "а";
    else if (num >= 92 && num <= 94) result += "а";
    else result += "ов";
    Console.WriteLine(result);
}
Console.WriteLine("Введите число программистов в комнате");
int num = Convert.ToInt32(Console.ReadLine());
ProgrammerLot(num);

// Задача полностью не выполнена
// НЕОБХОДИМО РАСПИСАТЬ УСЛОВИЯ ДОБАВЛЕНИЯ ОКОНЧАНИЙ.
// СЕЙЧАС РАСПИСАНА ДО 100 через диапазоны значений. Но это не универсальный вариант.