// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = 0;

for (int i = 1; num != 0; i++)
{
    num /= 10;
    res = i;
}
Console.WriteLine(res);