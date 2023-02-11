// Console.WriteLine("Введите число A ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int b = Convert.ToInt32(Console.ReadLine());
// int max = a;
// int min = b;

// if (a > b)
// {
//     Console.WriteLine("Число больше");
//     Console.WriteLine( max = a);
    
// }
// else
// {
//     Console.WriteLine("Число больше");
//     Console.WriteLine( min = b);
    
// }
// if (a < b)
// {
//     Console.WriteLine("Число меньше");
//     Console.WriteLine( max = a);
    
// }
// else
// {
//     Console.WriteLine("Число меньше");
//     Console.WriteLine( min = b);
    
// }


Console.WriteLine("Введите числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;

if (a > max) max = a;
if (a < min) min = a;
if (b > max) max = b;
if (b < min) min = b;
if (c > max) max = c;
if (c < min) min = c;

Console.WriteLine("Число max");
Console.WriteLine(max);
Console.WriteLine("Число min");
Console.WriteLine(min);