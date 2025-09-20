Console.WriteLine("Введите число x");
int x = Convert.ToInt32(Console.ReadLine());
int S = 1;
for(int i = 3; i <= x; i+=2)
{
    S *= i;
}
S *= x;
Console.WriteLine(S);
