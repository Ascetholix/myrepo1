// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();

int[] arrya = new int[8]; 
for (int i = 0; i < 8; i++)
{
    arrya[i]=new Random().Next(0,2);
    Console.WriteLine(arrya[i]);
}
