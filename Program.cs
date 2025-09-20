Console.WriteLine("Введите число x");
int x = Convert.ToInt32(Console.ReadLine());
int S = 1;
int i = 3;
while(i <= x)
{
    S *= i;
    i += 2;
}
S *= x;
Console.WriteLine(S);