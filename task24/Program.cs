// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

//int num = 4;
int res = 0;

for (int i = 1; i <= num; i++)
{
    res = res + i;
}
Console.WriteLine(res);