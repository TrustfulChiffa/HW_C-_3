// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int count = 1;

Console.Write($"{N} -> ");

 while (count < N)
    {
        Console.Write($"{Math.Pow(count, 3)}, ");
        count ++;
    }
    Console.Write(Math.Pow(N, 3));