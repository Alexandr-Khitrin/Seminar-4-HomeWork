Console.Write("Введите значение A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите значение B: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(Degree(a, b));
int Degree(int a, int b)
{
    int degree = 1;
    int i = 0;
    while (i < b)
    {
        degree *= a;
        i++;
    }
    return degree;
}