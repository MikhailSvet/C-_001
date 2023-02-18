Console.Clear();
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Все четные числа - "+ a);
int i = 1;
while (i < a)
{
    if (i % 2 == 0)
    {

        Console.WriteLine(i + "");
    }

    i++;
}
Console.Write(i);
