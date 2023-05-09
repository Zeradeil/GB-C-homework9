// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные 
// числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int M = Readnum("начало");
int N = Readnum("конец");
NaturalNumbers(M, N);


int Readnum(string massage)
{
    System.Console.Write($"Введите {massage} промежутка => ");
    return Convert.ToInt32(Console.ReadLine());
}

void NaturalNumbers(int M, int N)
{
    if (M % 2 != 0)
    {
        M += 1;
    }
    if (N >= M)
    {
        System.Console.Write($"{M} ");
        M += 2;
        NaturalNumbers(M, N);
    }
    return;
}

