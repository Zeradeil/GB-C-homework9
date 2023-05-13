// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int M = Readnum("начало");
int N = Readnum("конец");
int sum = 0;
System.Console.WriteLine(SumNumbers(M, N, sum));


int Readnum(string massage)
{
    System.Console.Write($"Введите {massage} промежутка => ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int M, int N, int sum)
{

    if (M % 2 != 0)
    {
        M += 1;
    }
    if (N < M)
    {
        return 0;
    }
    sum += M;
    System.Console.Write($"{M} ");
    M += 2;
    SumNumbers(M, N, sum);

    return sum += M;
}

