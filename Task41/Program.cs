// считает кол-во положительных чисел, введенных пользователем
Console.WriteLine("введите кол-во чисел");
int N = Convert.ToInt32(Console.ReadLine());
int CountPositive(int num)
{
int count = 0;
int number = 0;
    for (int i = 1; i <= num; i++)
    {
        Console.Write("Введите число  ");
        number = Convert.ToInt32(Console.ReadLine());
            if (number > 0) { count++;}
    }
    return count;
}
Console.WriteLine($"Вы ввели {CountPositive(N)} положительных чисел");