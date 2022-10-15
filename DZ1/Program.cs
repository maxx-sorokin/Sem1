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