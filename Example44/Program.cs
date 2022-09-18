/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1. f(n) = f(n-1) + f(n-2)
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int[] GetNumbersFibonachi(int n)
{
    int[] arrayNumbersFibonachi = new int[n];
    arrayNumbersFibonachi[0] = 0;
    arrayNumbersFibonachi[1] = 1;

    if (n < 2) return arrayNumbersFibonachi;
    else
    {
        for (int i = 2; i < arrayNumbersFibonachi.Length; i++)
        {
            arrayNumbersFibonachi[i] = arrayNumbersFibonachi[i - 1] + arrayNumbersFibonachi[i - 2];
        }
        return arrayNumbersFibonachi;
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

var numbersFibonachi = GetNumbersFibonachi(n);
Console.WriteLine("{0}", string.Join(" ", numbersFibonachi));