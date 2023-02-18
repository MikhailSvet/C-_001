// Напишите программу, которая выводит третью цифру заданного
//  числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num>99)
{
    int num2 = num%10;
    Console.WriteLine(num2);
}
else 
{
Console.WriteLine("Нет третьей цифры ");
}