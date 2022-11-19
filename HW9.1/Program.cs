// Показать натуральные числа от M до N, N и M заданы

void Numbers(int a, int b)
{
    if (a <= b)
    {
        Console.Write(a + " ");
        Numbers(a + 1, b);
    }
};
void Numbers2(int a, int b)
{
    if (a >= b)
    {
        Console.Write(a + " ");
        Numbers2(a - 1, b);
    }
};

Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
if(M>N)Numbers2(M,N);
else if(N>M)Numbers(M,N);
