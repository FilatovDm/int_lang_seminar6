/*
Задача 42: Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

string GetBinaryNumber(int number)
{
    string result = String.Empty;
    while (number > 0)
    {
        result = Convert.ToString(number % 2) + result;
        number = number / 2;
    }
    return result;
}

Console.Write("Введите десятичное число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

string binaryNumber = GetBinaryNumber(decimalNumber);
Console.Write($"Десятичное число {decimalNumber} в двоичном формате: {binaryNumber}");
