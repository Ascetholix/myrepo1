// ** Вводим с клавы число х - целое, а затем вводим х разных целых чисел. 
// Нужно вывести на экран самое большое и второе по величине число из введенных.

Console.Clear();                            //Очистка консоли
Console.Write("Введите длину массива : ");
int N = Convert.ToInt32(Console.ReadLine());

int[] arrya = new int[N];                 // Массив с длиной введеный пользоватилем
int n = N + 1;

for (int i = 0; i < N; i++)              // цикл заполнения массива
{
    Console.Write($"Введите {n -= 1} цифр: ");
    arrya[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();                       //Разделение строки

for (int i = 0; i < N; i++)                // цикл вывода  массива
{
    Console.WriteLine(arrya[i]);
}
                                        // начало поиска максумума и второго максимума
int max = arrya[0];                      //   переменая максимум
int secMax = arrya[0];                    //   переменая второго максимум

for (int i = 0; i < N - 1; i++)          // цикл поиска масимума
{      
    if (arrya[i] > max)
    {
        max = arrya[i];
    }
    else
    {
        for (int j = 0; j < N - 1; j++)     // цикл поиска второго максимума внутри первого цикла
        {
            if (arrya[j] > secMax)
            {
                if (secMax < max) secMax = arrya[j];
            }
        }

    }
}
Console.WriteLine();                                     //Разделение строки
Console.WriteLine($"Максимум : {max}");
Console.WriteLine($"Второй максимум  : {secMax}");