Console.WriteLine("Добрый день!");

Console.WriteLine("Введите 1-ое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-ое число");
int num3 = Convert.ToInt32(Console.ReadLine());

int max =  -2147483648;

if (num1>max)
{
    max = num1;
}

if (num2>max)
{
    max = num2;
}

if (num3>max)
{
    max = num3;
}

Console.Write("max = ");
Console.WriteLine(max);