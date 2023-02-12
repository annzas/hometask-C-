Console.Write("Введите первое число: ");
int firstN = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondN = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввидите третье число: ");
int thirdN = Convert.ToInt32(Console.ReadLine());

int max = firstN;

if (secondN>max)
{
    max=secondN;
}
if (thirdN>max)
{
    max=thirdN;
}
Console.WriteLine (max);