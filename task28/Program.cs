// Задача 28: Напишите программу, которая принимает на вход число N
//  и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = 1;
if (num > 0)
{
    for (int i = 1; i <= num; i++)
    {
        res = res * i;
    }
}
else if (num < 0)
{
    for (int i = -1; i >= num; i--)
    {
        res = res * i;
    }
}
else
{
    res = 0;
}
Console.WriteLine(res);