//1* Напиши программу,  где вводим три числа, а потом выводим сумму только положительных чисел.

Console.Clear();

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int numC = Convert.ToInt32(Console.ReadLine());

int sum = 0;

if (numA > 0 && numB>0 && numC>0) sum=numA+numB+numC;
else if (numA > 0 && numB>0) sum=numA+numB;
else if (numA > 0 && numC>0) sum=numA+numC;
else if (numB > 0 && numC>0) sum=numB+numC;
else if (numA > 0) sum=numA;
else if (numB > 0) sum=numB;
else if (numC > 0) sum=numC;
else Console.WriteLine("Все цифри отрицательны");

Console.WriteLine(sum);
