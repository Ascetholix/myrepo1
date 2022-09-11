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
        max = mas[i];
    }

    else
    {
        for (int j = 0; j < n - 1; j++)
        {
            if (mas[j] > smax)
            {
                if (max > smax)
                {
                    smax = mas[j];
                }
            }
        }



    }
}
Console.WriteLine(smax);
Console.WriteLine(max);