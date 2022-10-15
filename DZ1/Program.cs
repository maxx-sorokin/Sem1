Console.Clear();
Console.WriteLine("Введите номер задачи: 2, 4, 6 или 8");
int Z = Convert.ToInt32(Console.ReadLine());

// Задача №2
if (Z == 2)
{
    Console.WriteLine("Задача 2. Введите два числа");
    int A2 = Convert.ToInt32(Console.ReadLine());
    int B2 = Convert.ToInt32(Console.ReadLine());

    if (A2 > B2)
    {
        Console.WriteLine($"Число {A2} больше, чем число {B2}");
    }
    else
    {
        if (A2 == B2)
        {
            Console.WriteLine("Числа равны");
        }
        else
        {
            Console.WriteLine($"Число {B2} больше, чем число {A2}");
        }
    }
}

// Задача №4
if (Z == 4)
{
    Console.WriteLine("Задача 4. Введите три числа");
    int A4 = Convert.ToInt32(Console.ReadLine());
    int B4 = Convert.ToInt32(Console.ReadLine());
    int C4 = Convert.ToInt32(Console.ReadLine());

    if (A4 > B4)
    {
        if (A4 > C4)
        {
            Console.WriteLine($"Максимальное число {A4}");
        }
        else
        {
            Console.WriteLine($"Максимальное число {C4}");
        }
        }
    else
    {
        if (B4 > C4)
        {
            Console.WriteLine($"Максимальное число {B4}");
        }
        else
        {
            Console.WriteLine($"Максимальное число {C4}");
        }
    }
}

// Задача №6
if (Z == 6)
{
    Console.WriteLine("Задача 6. Введите число");
    int A6 = Convert.ToInt32(Console.ReadLine());

    if (A6 % 2 == 0)
    {
        Console.WriteLine($"Число {A6} - чётное");
    }
    else
    {
        Console.WriteLine($"Число {A6} - нечётное");
    }
}

// Задача №8
if (Z == 8)
{
    Console.WriteLine("Задача 8. Введите число");
    int N = Convert.ToInt32(Console.ReadLine());

    if (N > 1)
    {
        int i = 2;

        Console.WriteLine($"Чётные числа от 1 до {N}:");

        while (i < (N - 1))
        {
            Console.Write($"{i}, ");
            i += 2;
        }
        if (i <= N)
        {
            Console.Write(i);
        }
    }
    else    
    {
        Console.WriteLine("В заданном интервале чётных чисел нет");
    }
}

else
{
    Console.WriteLine("Некорректный номер задачи, попробуйте ещё раз");
}