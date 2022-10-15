Console.Clear();
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int i = -N;

while (i < N)
{
    Console.Write($"{i}, ");
    i++;
}

Console.Write(i);