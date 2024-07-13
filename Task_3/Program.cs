//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void Main()
{
    int size = ReadInt("введите размер массива: ");
    int[] array = GenerateArray(size, 1, 100);
    PrintArray(array);
    ConvertArray(array, array.Length - 1);

}

void ConvertArray(int[] array, int i)
{
    if (i < 0) return;
    System.Console.Write(array[i] + " ");
    ConvertArray(array, i - 1);

}

void PrintArray(int[] array)
{
    foreach (int i in array)
        System.Console.Write(i + " ");
    System.Console.WriteLine();
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tempArr = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArr.Length; i++)
        tempArr[i] = rand.Next(minValue, maxValue);

    return tempArr;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}


Main();
