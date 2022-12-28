/*Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.*/

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int count = number;
if (number < -99 )
{
    while (count < -999 )
    {
        count = count / 10;
    }
    Console.WriteLine($"Третьей цифрa числа {number} равна {count % 10 * -1}");
}
else if ( number > 99)
{
    while (count > 999)
    {
        count = count / 10;
    }
    Console.WriteLine($"Третьей цифрa числа {number} равна {count % 10}");
}
else Console.WriteLine("Третьей цифры нет");

