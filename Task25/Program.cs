// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("введите первое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int y = Convert.ToInt32(Console.ReadLine());


int getExtent = GetExtent(x, y);
Console.Write($"{x}, {y} -> {getExtent}");

int GetExtent(int x1, int y1)
{
    int count = 1;
    int result = 1;

    if (y1 < 0) 
    {
        y1 = -y1;

        while (count <= y1) 
        {
        count++;
        result = result * x1;
        }
    }

    else 
    {
    while (count <= y1) 
    {
        count++;
        result = result * x1;
    }
    }
     return result;
}