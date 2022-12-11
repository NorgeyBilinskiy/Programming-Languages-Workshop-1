Console.WriteLine("Добрый день!");
Console.WriteLine("Введите 1-ое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{
    Console.WriteLine("первое число больше второго");
    Console.Write("max = ");
    Console.WriteLine(num1);
  }
  if (num1<num2)
  {
    Console.WriteLine("второе число больше первого");
    Console.Write("max = ");
    Console.WriteLine(num2);
  }