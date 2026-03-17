// See https://aka.ms/new-console-template for more information
Console.WriteLine("Main before rebase");
Console.Write("Podaj pierwszą liczbę: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Podaj druga liczbe: ");
int b = int.Parse(Console.ReadLine());

if (a < 0 || b < 0)
{
    Console.WriteLine("Liczby muszą być dodatnie!");
    return;
}

int result = Multiply(a,b);
Console.WriteLine("Wynik z feature branch: " + result);

int[] numbers = {a,b};
double avg = CalculateAverage(numbers);
Console.WriteLine("Średnia: " + avg);

int max = CalculateMax(a, b);
Console.WriteLine("Max calculated: " + max);

int min = CalculateMin(a, b);
Console.WriteLine("Min Value: " + min);

static int Multiply(int a, int b)
{
    return a * b;
}

static double CalculateAverage(int[] values)
{
    return values.Average();
}

static int CalculateAverage(int a, int b)
{
    return Math.Max(a, b);
}

static int CalculateMin(int a, int b)
{
    return Math.Min(a, b);
}