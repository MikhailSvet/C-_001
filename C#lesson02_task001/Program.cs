//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//последнюю цифру этого числа.
// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
//     int lastNumber = number % 10;
//     System.Console.WriteLine("Последнее число: " + lastNumber);
// }
// else
// {
//     System.Console.WriteLine("Неправильный номер: ");
// }

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Через строку решать нельзя. 456 -> 5

Console.Clear();
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int y = a / 10;
int c = y % 10;
if (a > 99 && a < 1000)
{
    Console.WriteLine("Второе число ");
}
Console.WriteLine(c);