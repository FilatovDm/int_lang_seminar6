/*
Задача 39: Напишите программу, которая перевернёт одномерный 
массив (последний элемент будет на первом месте, а первый - 
на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int[] GetReverseArray1(int[] array)
{
    int[] newArray = new int[array.Length];

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[array.Length - i - 1];
    }
    return newArray;
}


int[] GetReverseArray2(int[] array)
{
    int tempStorage = array[0];
    for (int i = 0; i < (array.Length / 2); i++)
    {
        tempStorage = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = tempStorage;
    }
    return array;
}

int[] array = new int[] { 1, 2, 3, 4, 5, 12 };
int[] resultArray = GetReverseArray2(array);

Console.WriteLine("[{0}]", string.Join(", ", resultArray));