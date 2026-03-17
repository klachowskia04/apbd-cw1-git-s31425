// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Git!");
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
Console.WriteLine("Wynik: " + result);

static int Multiply(int a, int b)
{
    return a * b;
}