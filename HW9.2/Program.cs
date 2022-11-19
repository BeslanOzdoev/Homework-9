// Найти сумму элементов от M до N, N и M заданы
int Summ(int a, int b)
{
    if (a == b) return b;
    return a + Summ(a + 1, b);
};

Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine() ?? "0");

if (M > N) Console.WriteLine(Summ(N, M));
else if (N > M) Console.WriteLine(Summ(M, N));