/*
Задача 40: Напишите программу, которая принимает на вход три числа и 
проверяет, может ли существовать треугольник с сторонами такой длины.
**Теорема о неравенстве треугольника: каждая сторона треугольника 
меньше суммы двух других сторон.**
*/

bool GetTriangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    else return false;

}

Console.Write("Введите длину первой стороны: ");
int length1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину первой стороны: ");
int length2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину первой стороны: ");
int length3 = Convert.ToInt32(Console.ReadLine());

bool resultTriangle = GetTriangle(length1, length2, length3);

if (resultTriangle == true)
{
    Console.WriteLine($"Треуголник со сторонами {length1}, {length2}, {length3} может существовать");
}
else
{
    Console.WriteLine($"Треуголник со сторонами {length1}, {length2}, {length3} не может существовать");
}