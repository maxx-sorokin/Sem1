Console.Clear();
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int i = -N;

while (i < N)
{
    Console.Write(i);
    Console.Write(", ");
    i += 1;
}

Console.Write(i);