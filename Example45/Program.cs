/*
 Задача 45: Напишите программу, которая будет создавать копию 
 заданного массива с помощью поэлементного копирования.
*/

int[] GetCopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];

    for (int i = 0; i < copyArray.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

int[] inputArray = new int[] {23, -5, 6, 0, 69};
int[] copyArray = GetCopyArray(inputArray);

System.Console.WriteLine("[{0}]", string.Join(", ", copyArray));
