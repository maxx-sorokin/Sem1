Console.Clear();
Console.WriteLine("Введите два числа:");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

int square = numberB * numberB;

if (square == numberA)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}