// ** Вводим с клавы число х - целое, а затем вводим х разных целых чисел. 
// Нужно вывести на экран самое большое и второе по величине число из введенных.

Console.Clear();                            //Очистка консоли
Console.Write("Введите длину массива : ");
int N = Convert.ToInt32(Console.ReadLine());

int[] arrya = new int[N];                 // Массив с длиной введеный пользоватилем


for (int i = 0; i < N; i++)              // цикл заполнения массива
{
    Console.Write($"Введите {i+1} цифр: ");
    arrya[i] = Convert.ToInt32(Console.ReadLine());
}

// начало поиска максумума и второго максимума

int max = arrya[0];                      //   переменая максимум
int secMax = arrya[0];                    //   переменая второго максимум

for (int i = 0; i < N - 1; i++)          // цикл поиска масимума
{
    if (arrya[i] > max)
    {
        secMax = max;                  // второй максимум равно старому максимуму
        max = arrya[i];                // новый макс
    }
}
Console.WriteLine();                                     //Разделение строки
Console.WriteLine($"Максимум : {max}");
Console.WriteLine($"Второй максимум  : {secMax}");