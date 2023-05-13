// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

int m =  Readnum("M");
int n = Readnum("N");
int ack = Ackermann(m, n);
System.Console.WriteLine(ack);

int Readnum(string massage)
{
    System.Console.Write($"Введите {massage} => ");
    return Convert.ToInt32(Console.ReadLine());
}

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0 && m > 0)
    {
        return Ackermann(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    return Ackermann(m, n);
}