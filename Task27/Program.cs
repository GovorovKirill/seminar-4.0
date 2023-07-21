// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());

int getSumGigit = GetSumGigit(number);
Console.Write($"{number} -> {getSumGigit}");

int GetSumGigit(int num)
{
    int result = 0;
    int digit = 1;

    if (num < 0)
    {
        num = -num;

        while (num >= 1)
        {
            digit = num % 10;
            result = result + digit;
            num = num / 10;
        }
    }

    else
    {
        while (num >= 1)
        {
            digit = num % 10;
            result = result + digit;
            num = num / 10;
        }
    }


    return result;
}