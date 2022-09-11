// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


int[] mas = { 11, 23, 322, 142, 15, 6, 7, 998, 69 };
int n = mas.Length;
int max = mas[0];
int smax = mas[0];

for (int i = 0; i < n - 1; i++)
{
    if (mas[i] > max)
    {
        smax = max;
        max = mas[i];
    }
}

Console.WriteLine(smax);
Console.WriteLine(max);